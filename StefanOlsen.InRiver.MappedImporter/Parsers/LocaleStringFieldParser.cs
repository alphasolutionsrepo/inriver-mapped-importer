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

﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.XPath;
using inRiver.Remoting.Objects;
using StefanOlsen.InRiver.MappedImporter.Models.Mapping;

namespace StefanOlsen.InRiver.MappedImporter.Parsers
{
    public class LocaleStringFieldParser : IFieldParser
    {
        private readonly IDictionary<string, CultureInfo> _supportedCultures;

        public LocaleStringFieldParser(
            IDictionary<string, CultureInfo> supportedCultures)
        {
            _supportedCultures = supportedCultures;
        }

        public object GetAttributeValue(XPathNavigator parentNode, BaseField fieldMapping, string attributeName)
        {
            throw new NotSupportedException();
        }

        public object GetElementValue(XPathNavigator parentNode, BaseField fieldMapping, XPathExpression xpath)
        {
            var localeString = new LocaleString();
            var localizedNodes = parentNode.Select(xpath);

            foreach (XPathNavigator localizedNode in localizedNodes)
            {
                string langKey = localizedNode.XmlLang;

                if (string.IsNullOrEmpty(langKey) ||
                    !_supportedCultures.TryGetValue(langKey, out CultureInfo culture))
                {
                    continue;
                }

                string value = localizedNode.Value;
                localeString[culture] = value;
            }

            return localeString;
        }
    }
}
