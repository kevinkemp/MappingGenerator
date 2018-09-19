﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MappingGenerator.Test.ImplementCloneMethod {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ImplementCloneMethodTestCases {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ImplementCloneMethodTestCases() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MappingGenerator.Test.ImplementCloneMethod.ImplementCloneMethodTestCases", typeof(ImplementCloneMethodTestCases).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///using System.Collections.ObjectModel;
        ///
        ///namespace MappingGenerator.Test.MappingGenerator.TestCaseData
        ///{
        ///    public class BaseDTO
        ///    {
        ///        public long Id { get; set;}
        ///    }
        ///
        ///    public class [|UserDTO|] : BaseDTO
        ///    {
        ///        public string FirstName { get; }
        ///        public string LastName { get; private set; }
        ///        public int Age { get; set; }
        ///        public int Cash { get;}
        ///        public AccountDTO Account { get; p [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _001_DeepClone {
            get {
                return ResourceManager.GetString("_001_DeepClone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///using System.Collections.ObjectModel;
        ///
        ///namespace MappingGenerator.Test.MappingGenerator.TestCaseData
        ///{
        ///    public class BaseDTO
        ///    {
        ///        public long Id { get; set;}
        ///    }
        ///
        ///    public class UserDTO : BaseDTO, System.ICloneable
        ///    {
        ///        public string FirstName { get; }
        ///        public string LastName { get; private set; }
        ///        public int Age { get; set; }
        ///        public int Cash { get;}
        ///        public AccountDTO A [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _001_DeepClone_FIXED {
            get {
                return ResourceManager.GetString("_001_DeepClone_FIXED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///using System.Collections.ObjectModel;
        ///
        ///namespace MappingGenerator.Test.MappingGenerator.TestCaseData
        ///{
        ///    public class Classx : ICloneable
        ///    {
        ///        public string A { get; set; }
        ///        public string B { get; set; }
        ///
        ///        public Classx Clone()
        ///        {
        ///            return new Classx()
        ///            {
        ///                A = A,
        ///                B = B
        ///            };
        ///        }
        ///
        ///        object ICloneable.Clone()
        ///        { [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _002_DetecCloneOnMembers {
            get {
                return ResourceManager.GetString("_002_DetecCloneOnMembers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///using System.Collections.ObjectModel;
        ///
        ///namespace MappingGenerator.Test.MappingGenerator.TestCaseData
        ///{
        ///    public class Classx : ICloneable
        ///    {
        ///        public string A { get; set; }
        ///        public string B { get; set; }
        ///
        ///        public Classx Clone()
        ///        {
        ///            return new Classx()
        ///            {
        ///                A = A,
        ///                B = B
        ///            };
        ///        }
        ///
        ///        object ICloneable.Clone()
        ///        { [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _002_DetecCloneOnMembers_FIXED {
            get {
                return ResourceManager.GetString("_002_DetecCloneOnMembers_FIXED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///
        ///namespace MappingGenerator.Test.MappingGenerator.TestCaseData
        ///{
        ///    public class ClassX
        ///    {
        ///        public string A { get; set; }
        ///        public string B { get; set; }
        ///
        ///        public ClassX [|Clone|]()
        ///        {
        ///        }
        ///    }
        ///}.
        /// </summary>
        internal static string _003_ImplementCloneMethodBody {
            get {
                return ResourceManager.GetString("_003_ImplementCloneMethodBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///
        ///namespace MappingGenerator.Test.MappingGenerator.TestCaseData
        ///{
        ///    public class ClassX
        ///    {
        ///        public string A { get; set; }
        ///        public string B { get; set; }
        ///
        ///        public ClassX Clone()
        ///        {
        ///            return new ClassX()
        ///            {
        ///                A = A,
        ///                B = B
        ///            };
        ///        }
        ///    }
        ///}.
        /// </summary>
        internal static string _003_ImplementCloneMethodBody_FIXED {
            get {
                return ResourceManager.GetString("_003_ImplementCloneMethodBody_FIXED", resourceCulture);
            }
        }
    }
}