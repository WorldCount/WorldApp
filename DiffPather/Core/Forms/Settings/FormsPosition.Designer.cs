﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DiffPather.Core.Forms.Settings
{
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class FormsPosition : global::System.Configuration.ApplicationSettingsBase
    {

        private static FormsPosition defaultInstance = ((FormsPosition)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new FormsPosition())));

        public static FormsPosition Default
        {
            get
            {
                return defaultInstance;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Normal")]
        public global::System.Windows.Forms.FormWindowState GeneralFormState
        {
            get
            {
                return ((global::System.Windows.Forms.FormWindowState)(this["GeneralFormState"]));
            }
            set
            {
                this["GeneralFormState"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Point GeneralFormLocation
        {
            get
            {
                return ((global::System.Drawing.Point)(this["GeneralFormLocation"]));
            }
            set
            {
                this["GeneralFormLocation"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Size GeneralFormSize
        {
            get
            {
                return ((global::System.Drawing.Size)(this["GeneralFormSize"]));
            }
            set
            {
                this["GeneralFormSize"] = value;
            }
        }
    }
}
