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
using System.Xml.XPath;

namespace StefanOlsen.InRiver.MappedImporter.Parsers
{
    public class DateTimeFieldParser : IFieldParser
    {
        public object GetAttributeValue(XPathNavigator parentNode, string attributeName)
        {
            string value = parentNode.GetAttribute(attributeName, string.Empty);

            DateTime? dateTime = GetDateTime(value);

            return dateTime;
        }

        public object GetElementValue(XPathNavigator parentNode, XPathExpression xpath)
        {
            var node = parentNode.SelectSingleNode(xpath);
            string value = node?.Value;

            DateTime? dateTime = GetDateTime(value);

            return dateTime;
        }

        private static DateTime? GetDateTime(string value)
        {
            if (value != null &&
                DateTime.TryParse(value, out DateTime result))
            {
                return result;
            }

            return null;
        }
    }
}
