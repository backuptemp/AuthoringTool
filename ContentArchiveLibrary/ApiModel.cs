﻿// Decompiled with JetBrains decompiler
// Type: Nintendo.Authoring.AuthoringLibrary.ApiModel
// Assembly: ContentArchiveLibrary, Version=1.0.6136.25605, Culture=neutral, PublicKeyToken=null
// MVID: 01E302F0-EDFB-4BCF-933A-7A8E0F9F4AED
// Assembly location: E:\AuthoringTool\ContentArchiveLibrary.dll

using System.Xml.Serialization;

namespace Nintendo.Authoring.AuthoringLibrary
{
  [XmlRoot("Api")]
  public class ApiModel
  {
    [XmlElement("ApiName", IsNullable = false)]
    public string ApiName { get; set; }

    [XmlElement("NsoName", IsNullable = false)]
    public string NsoName { get; set; }
  }
}
