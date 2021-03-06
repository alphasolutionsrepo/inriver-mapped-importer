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

// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.1.34438 Microsoft Reciprocal License (Ms-RL) 
//    <NameSpace>StefanOlsen.InRiver.MappedImporter.Models.Mapping</NameSpace><Collection>Array</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>True</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>True</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>True</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace StefanOlsen.InRiver.MappedImporter.Models.Mapping
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping", IsNullable = false)]
    public partial class Languages
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        private LanguageMapping[] languageField;

        [System.Xml.Serialization.XmlElementAttribute("Language")]
        public LanguageMapping[] Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping", IsNullable = true)]
    public partial class LanguageMapping
    {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Original { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InRiver { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping", IsNullable = false)]
    public partial class ImportMapping
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        private XmlNamespace[] xmlNamespacesField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private LanguageMapping[] languagesField;

        public EntityMapping Entity { get; set; }


        [System.Xml.Serialization.XmlArrayItemAttribute("Namespace", IsNullable = false)]
        public XmlNamespace[] XmlNamespaces
        {
            get
            {
                return this.xmlNamespacesField;
            }
            set
            {
                this.xmlNamespacesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("Language", IsNullable = false)]
        public LanguageMapping[] Languages
        {
            get
            {
                return this.languagesField;
            }
            set
            {
                this.languagesField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping", IsNullable = true)]
    public partial class XmlNamespace
    {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Prefix { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Uri { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping", IsNullable = true)]
    public partial class EntityMapping : BaseEntityMapping
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        private EntityMapping[] entityField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private LinkMapping[] childLinksField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private LinkMapping[] parentLinksField;

        public FieldSets FieldSets { get; set; }


        [System.Xml.Serialization.XmlElementAttribute("Entity")]
        public EntityMapping[] Entity
        {
            get
            {
                return this.entityField;
            }
            set
            {
                this.entityField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("Link", IsNullable = false)]
        public LinkMapping[] ChildLinks
        {
            get
            {
                return this.childLinksField;
            }
            set
            {
                this.childLinksField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("Link", IsNullable = false)]
        public LinkMapping[] ParentLinks
        {
            get
            {
                return this.parentLinksField;
            }
            set
            {
                this.parentLinksField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping", IsNullable = true)]
    public partial class FieldSets
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        private FieldSet[] fieldSetField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string XPath { get; set; }


        [System.Xml.Serialization.XmlElementAttribute("FieldSet")]
        public FieldSet[] FieldSet
        {
            get
            {
                return this.fieldSetField;
            }
            set
            {
                this.fieldSetField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping", IsNullable = true)]
    public partial class FieldSet
    {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FieldSetName { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping", IsNullable = true)]
    public partial class LinkMapping
    {

        public LinkEntityMapping LinkEntity { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LinkType { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SourcePath { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TargetUniqueFieldType { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping", IsNullable = true)]
    public partial class LinkEntityMapping : BaseEntityMapping
    {
    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinkEntityMapping))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityMapping))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping", IsNullable = true)]
    public abstract partial class BaseEntityMapping
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        private BaseField[] fieldsField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EntityType { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Root { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UniqueFieldType { get; set; }


        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(BooleanField), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(CvlField), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(DateTimeField), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(IntegerField), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(LocaleStringField), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(SKUField), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(StringField), IsNullable = false)]
        public BaseField[] Fields
        {
            get
            {
                return this.fieldsField;
            }
            set
            {
                this.fieldsField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping", IsNullable = true)]
    public partial class BooleanField : BaseField
    {
    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SKUField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CvlField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StringField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocaleStringField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DateTimeField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BooleanField))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping", IsNullable = true)]
    public abstract partial class BaseField
    {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FieldType { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ElementPath { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AttributeName { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping", IsNullable = true)]
    public partial class SKUField : BaseField
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        private SKUElement[] sKUElementField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string KeyAttribute { get; set; }


        [System.Xml.Serialization.XmlElementAttribute("SKUElement")]
        public SKUElement[] SKUElement
        {
            get
            {
                return this.sKUElementField;
            }
            set
            {
                this.sKUElementField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping", IsNullable = true)]
    public partial class SKUElement
    {

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ElementPath { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping", IsNullable = true)]
    public partial class CvlField : BaseField
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        private bool addValuesField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private bool multivalueField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string separatorField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Cvl { get; set; }


        public CvlField()
        {
            this.addValuesField = false;
            this.multivalueField = false;
            this.separatorField = ",";
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AddValues
        {
            get
            {
                return this.addValuesField;
            }
            set
            {
                this.addValuesField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Multivalue
        {
            get
            {
                return this.multivalueField;
            }
            set
            {
                this.multivalueField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(",")]
        public string Separator
        {
            get
            {
                return this.separatorField;
            }
            set
            {
                this.separatorField = value;
            }
        }
    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocaleStringField))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping", IsNullable = true)]
    public partial class StringField : BaseField
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping", IsNullable = true)]
    public partial class LocaleStringField : StringField
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping", IsNullable = true)]
    public partial class IntegerField : BaseField
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping", IsNullable = true)]
    public partial class DateTimeField : BaseField
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping", IsNullable = true)]
    public partial class XmlNamespaces
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        private XmlNamespace[] namespaceField;

        [System.Xml.Serialization.XmlElementAttribute("Namespace")]
        public XmlNamespace[] Namespace
        {
            get
            {
                return this.namespaceField;
            }
            set
            {
                this.namespaceField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping", IsNullable = true)]
    public partial class Fields
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        private BaseField[] itemsField;

        [System.Xml.Serialization.XmlElementAttribute("BooleanField", typeof(BooleanField))]
        [System.Xml.Serialization.XmlElementAttribute("CvlField", typeof(CvlField))]
        [System.Xml.Serialization.XmlElementAttribute("DateTimeField", typeof(DateTimeField))]
        [System.Xml.Serialization.XmlElementAttribute("IntegerField", typeof(IntegerField))]
        [System.Xml.Serialization.XmlElementAttribute("LocaleStringField", typeof(LocaleStringField))]
        [System.Xml.Serialization.XmlElementAttribute("SKUField", typeof(SKUField))]
        [System.Xml.Serialization.XmlElementAttribute("StringField", typeof(StringField))]
        public BaseField[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.stefanolsen.com/inRiver/ImportMapping", IsNullable = true)]
    public partial class Links
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        private LinkMapping[] linkField;

        [System.Xml.Serialization.XmlElementAttribute("Link")]
        public LinkMapping[] Link
        {
            get
            {
                return this.linkField;
            }
            set
            {
                this.linkField = value;
            }
        }
    }
}
