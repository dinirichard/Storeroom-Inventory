﻿#pragma checksum "C:\Users\Dini Home\source\repos\App4\App4\Views\AddItemDialog.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E7DF1DB70294543E49F5AED14F7C2929"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App4.Views
{
    partial class AddItemDialog : 
        global::Windows.UI.Xaml.Controls.ContentDialog, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBox_Text(global::Windows.UI.Xaml.Controls.TextBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class AddItemDialog_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IAddItemDialog_Bindings
        {
            private global::App4.Views.AddItemDialog dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBox obj6;
            private global::Windows.UI.Xaml.Controls.TextBox obj7;
            private global::Windows.UI.Xaml.Controls.TextBox obj8;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj6TextDisabled = false;
            private static bool isobj7TextDisabled = false;
            private static bool isobj8TextDisabled = false;

            private AddItemDialog_obj1_BindingsTracking bindingsTracking;

            public AddItemDialog_obj1_Bindings()
            {
                this.bindingsTracking = new AddItemDialog_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 99 && columnNumber == 55)
                {
                    isobj6TextDisabled = true;
                }
                else if (lineNumber == 91 && columnNumber == 56)
                {
                    isobj7TextDisabled = true;
                }
                else if (lineNumber == 82 && columnNumber == 52)
                {
                    isobj8TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 6: // Views\AddItemDialog.xaml line 99
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_6(this.obj6);
                        break;
                    case 7: // Views\AddItemDialog.xaml line 91
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_7(this.obj7);
                        break;
                    case 8: // Views\AddItemDialog.xaml line 82
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_8(this.obj8);
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                throw new global::System.NotImplementedException();
            }

            public void Recycle()
            {
                throw new global::System.NotImplementedException();
            }

            // IAddItemDialog_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::App4.Views.AddItemDialog)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::App4.Views.AddItemDialog obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_newItem(obj.newItem, phase);
                    }
                }
            }
            private void Update_newItem(global::App4.Core.Models.Items obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_newItem(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_newItem_Barcode(obj.Barcode, phase);
                        this.Update_newItem_Location(obj.Location, phase);
                        this.Update_newItem_Name(obj.Name, phase);
                    }
                }
            }
            private void Update_newItem_Barcode(global::System.Int64 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\AddItemDialog.xaml line 99
                    if (!isobj6TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj6, obj.ToString(), null);
                    }
                }
            }
            private void Update_newItem_Location(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\AddItemDialog.xaml line 91
                    if (!isobj7TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj7, obj, null);
                    }
                }
            }
            private void Update_newItem_Name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\AddItemDialog.xaml line 82
                    if (!isobj8TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj8, obj, null);
                    }
                }
            }
            private void UpdateTwoWay_6_Text()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.newItem != null)
                        {
                            this.dataRoot.newItem.Barcode = (global::System.Int64) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Int64), this.obj6.Text);
                        }
                    }
                }
            }
            private void UpdateTwoWay_7_Text()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.newItem != null)
                        {
                            this.dataRoot.newItem.Location = this.obj7.Text;
                        }
                    }
                }
            }
            private void UpdateTwoWay_8_Text()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.newItem != null)
                        {
                            this.dataRoot.newItem.Name = this.obj8.Text;
                        }
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class AddItemDialog_obj1_BindingsTracking
            {
                private global::System.WeakReference<AddItemDialog_obj1_Bindings> weakRefToBindingObj; 

                public AddItemDialog_obj1_BindingsTracking(AddItemDialog_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<AddItemDialog_obj1_Bindings>(obj);
                }

                public AddItemDialog_obj1_Bindings TryGetBindingObject()
                {
                    AddItemDialog_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_newItem(null);
                }

                public void PropertyChanged_newItem(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    AddItemDialog_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::App4.Core.Models.Items obj = sender as global::App4.Core.Models.Items;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_newItem_Barcode(obj.Barcode, DATA_CHANGED);
                                bindings.Update_newItem_Location(obj.Location, DATA_CHANGED);
                                bindings.Update_newItem_Name(obj.Name, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Barcode":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_newItem_Barcode(obj.Barcode, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Location":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_newItem_Location(obj.Location, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Name":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_newItem_Name(obj.Name, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::App4.Core.Models.Items cache_newItem = null;
                public void UpdateChildListeners_newItem(global::App4.Core.Models.Items obj)
                {
                    if (obj != cache_newItem)
                    {
                        if (cache_newItem != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_newItem).PropertyChanged -= PropertyChanged_newItem;
                            cache_newItem = null;
                        }
                        if (obj != null)
                        {
                            cache_newItem = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_newItem;
                        }
                    }
                }
                public void RegisterTwoWayListener_6(global::Windows.UI.Xaml.Controls.TextBox sourceObject)
                {
                    sourceObject.LostFocus += (sender, e) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_6_Text();
                        }
                    };
                }
                public void RegisterTwoWayListener_7(global::Windows.UI.Xaml.Controls.TextBox sourceObject)
                {
                    sourceObject.LostFocus += (sender, e) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_7_Text();
                        }
                    };
                }
                public void RegisterTwoWayListener_8(global::Windows.UI.Xaml.Controls.TextBox sourceObject)
                {
                    sourceObject.LostFocus += (sender, e) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_8_Text();
                        }
                    };
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // Views\AddItemDialog.xaml line 1
                {
                    global::Windows.UI.Xaml.Controls.ContentDialog element1 = (global::Windows.UI.Xaml.Controls.ContentDialog)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentDialog)element1).PrimaryButtonClick += this.ContentDialog_PrimaryButtonClick;
                    ((global::Windows.UI.Xaml.Controls.ContentDialog)element1).SecondaryButtonClick += this.ContentDialog_SecondaryButtonClick;
                }
                break;
            case 2: // Views\AddItemDialog.xaml line 84
                {
                    this.NameError = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // Views\AddItemDialog.xaml line 106
                {
                    this.StackQuantity = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4: // Views\AddItemDialog.xaml line 114
                {
                    this.Amount = (global::Telerik.UI.Xaml.Controls.Input.RadNumericBox)(target);
                    ((global::Telerik.UI.Xaml.Controls.Input.RadNumericBox)this.Amount).ValueChanged += this.Amount_ValueChanged;
                }
                break;
            case 5: // Views\AddItemDialog.xaml line 107
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element5 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element5).SelectionChanged += this.TextBlock_SelectionChanged;
                }
                break;
            case 6: // Views\AddItemDialog.xaml line 99
                {
                    this.BarcodeName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // Views\AddItemDialog.xaml line 91
                {
                    this.LocationName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // Views\AddItemDialog.xaml line 82
                {
                    this.ItemName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.ItemName).TextChanged += this.ItemName_TextChanged;
                }
                break;
            case 9: // Views\AddItemDialog.xaml line 77
                {
                    this.name = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\AddItemDialog.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.ContentDialog element1 = (global::Windows.UI.Xaml.Controls.ContentDialog)target;
                    AddItemDialog_obj1_Bindings bindings = new AddItemDialog_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

