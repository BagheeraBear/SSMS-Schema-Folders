﻿using Microsoft.VisualStudio.Shell;
using System.ComponentModel;

namespace SsmsSchemaFolders
{
    public class SchemaFolderOptions : DialogPage
    {
        [Category("Enabled")]
        [DisplayName("Enabled")]
        [Description("Group sql objects in Object Explorer (tables, views, etc.) into schema folders.")]
        public bool Enabled { get; set; } = true;

        [Category("Folder Display Options")]
        [DisplayName("Append Dot")]
        [Description("Add a dot after the schema name on the folder label. ")]
        public bool AppendDot { get; set; } = true;

        [Category("Folder Display Options")]
        [DisplayName("Clone Parent Node")]
        [Description("Add the right click and drag and drop functionality of the parent node to the schema folder node.")]
        public bool CloneParentNode { get; set; } = true;

        [Category("Folder Display Options")]
        [DisplayName("Use Object Icon")]
        [Description("Use the icon of the first child node as the folder icon. If false then use the parent node (i.e. folder) icon.")]
        public bool UseObjectIcon { get; set; } = true;
    }
}
