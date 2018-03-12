/*
 * Copyright (c) 2018 Stefan Holm Olsen
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

﻿using System.Collections.Generic;
using System.Xml;
using System.Xml.XPath;
using StefanOlsen.InRiver.MappedImporter.Models;
using StefanOlsen.InRiver.MappedImporter.Models.Mapping;
using StefanOlsen.InRiver.MappedImporter.Parsers;

namespace StefanOlsen.InRiver.MappedImporter.Mappers
{
    public class EntityMapper
    {
        private readonly IXmlNamespaceResolver _namespaceResolver;
        private readonly ImportMapping _importMapping;
        private readonly FieldParserFactory _fieldParserFactory;
        private readonly IDictionary<string, XPathExpression> _cachedXPathExpressions;

        internal EntityMapper(IXmlNamespaceResolver namespaceResolver, ImportMapping importMapping)
        {
            _namespaceResolver = namespaceResolver;
            _importMapping = importMapping;

            _fieldParserFactory = new FieldParserFactory(namespaceResolver, importMapping);
            _cachedXPathExpressions = new Dictionary<string, XPathExpression>();
        }

        public IEnumerable<MappedEntity> GetEntities(XPathNavigator parentNode, EntityMapping entityMapping)
        {
            if (entityMapping?.Entity == null)
            {
                yield break;
            }

            var entityNodes = parentNode.Select(entityMapping.Root, _namespaceResolver);
            foreach (XPathNavigator entityNode in entityNodes)
            {
                MappedEntity entity = GetEntity(entityNode, entityMapping);

                yield return entity;
            }
        }

        public MappedEntity GetEntity(XPathNavigator parentNode, EntityMapping entityMapping)
        {
            //IEnumerable<MappedEntity> childEntities = GetEntities(parentNode, entityMapping);

            var mappedEntity = new MappedEntity();
            mappedEntity.EntityType = entityMapping.EntityType;
            mappedEntity.Fields = GetFields(parentNode, entityMapping);

            return mappedEntity;
        }

        private MappedEntity GetEntity()
        {
            return null;
        }

        private IEnumerable<MappedField> GetFields(XPathNavigator parentNode, EntityMapping entityMapping)
        {
            if (entityMapping?.Fields == null)
            {
                yield break;
            }

            foreach (BaseField fieldMapping in entityMapping.Fields)
            {
                object fieldValue = GetFieldValue(parentNode, fieldMapping);
                
                var mappedField = new MappedField(fieldMapping.FieldType, fieldValue);

                yield return mappedField;
            }
        }

        private object GetFieldValue(XPathNavigator parentNode, BaseField fieldMapping)
        {
            IFieldParser fieldParser = _fieldParserFactory.GetFieldParser(fieldMapping);

            object value = null;
            if (!string.IsNullOrWhiteSpace(fieldMapping.ElementPath))
            {
                XPathExpression xPathExpression = GetCachedExpression(fieldMapping.ElementPath);
                value = fieldParser.GetElementValue(parentNode, xPathExpression);
            }
            else if (!string.IsNullOrWhiteSpace(fieldMapping.AttributeName))
            {
                value = fieldParser.GetAttributeValue(parentNode, fieldMapping.AttributeName);
            }

            return value;
        }

        private XPathExpression GetCachedExpression(string xpath)
        {
            if (_cachedXPathExpressions.TryGetValue(xpath, out XPathExpression xPathExpression))
            {
                return xPathExpression;
            }

            xPathExpression = XPathExpression.Compile(xpath, _namespaceResolver);
            _cachedXPathExpressions.Add(xpath, xPathExpression);

            return xPathExpression;
        }
    }
}
