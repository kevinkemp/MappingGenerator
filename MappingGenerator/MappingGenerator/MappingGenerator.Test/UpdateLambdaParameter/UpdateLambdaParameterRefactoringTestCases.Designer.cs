﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MappingGenerator.Test.UpdateLambdaParameter {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class UpdateLambdaParameterRefactoringTestCases {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal UpdateLambdaParameterRefactoringTestCases() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MappingGenerator.Test.UpdateLambdaParameter.UpdateLambdaParameterRefactoringTestC" +
                            "ases", typeof(UpdateLambdaParameterRefactoringTestCases).Assembly);
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
        ///
        ///namespace ConsoleApp9
        ///{
        ///    public class User
        ///    {
        ///        public int Id { get; set; }
        ///
        ///        public string Name { get; set; }
        ///
        ///        public string Tenant { get; set; }
        ///    }
        ///
        ///    public class UserView
        ///    {
        ///        public int Id { get; set; }
        ///
        ///        public string Name { get; set; }
        ///
        ///        public string Tenant { get; set; }
        ///    }
        ///
        ///    public static class Examples
        ///    {
        ///        public static void Process(User user)
        ///        {
        ///            Update(userView =&gt; {[| [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _001_SimpleLambda {
            get {
                return ResourceManager.GetString("_001_SimpleLambda", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///
        ///namespace ConsoleApp9
        ///{
        ///    public class User
        ///    {
        ///        public int Id { get; set; }
        ///
        ///        public string Name { get; set; }
        ///
        ///        public string Tenant { get; set; }
        ///    }
        ///
        ///    public class UserView
        ///    {
        ///        public int Id { get; set; }
        ///
        ///        public string Name { get; set; }
        ///
        ///        public string Tenant { get; set; }
        ///    }
        ///
        ///    public static class Examples
        ///    {
        ///        public static void Process(User user)
        ///        {
        ///            Update(userView =&gt;
        ///   [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _001_SimpleLambda_FIXED {
            get {
                return ResourceManager.GetString("_001_SimpleLambda_FIXED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///
        ///namespace ConsoleApp9
        ///{
        ///    public class User
        ///    {
        ///        public int Id { get; set; }
        ///
        ///        public string Name { get; set; }
        ///
        ///        public string Tenant { get; set; }
        ///    }
        ///
        ///    public class UserView
        ///    {
        ///        public int Id { get; set; }
        ///
        ///        public string Name { get; set; }
        ///
        ///        public string Tenant { get; set; }
        ///    }
        ///
        ///    public static class Examples
        ///    {
        ///        public static void Process(User user)
        ///        {
        ///            Update((userView) =&gt; { [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _002_ParenthesisLambda {
            get {
                return ResourceManager.GetString("_002_ParenthesisLambda", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///
        ///namespace ConsoleApp9
        ///{
        ///    public class User
        ///    {
        ///        public int Id { get; set; }
        ///
        ///        public string Name { get; set; }
        ///
        ///        public string Tenant { get; set; }
        ///    }
        ///
        ///    public class UserView
        ///    {
        ///        public int Id { get; set; }
        ///
        ///        public string Name { get; set; }
        ///
        ///        public string Tenant { get; set; }
        ///    }
        ///
        ///    public static class Examples
        ///    {
        ///        public static void Process(User user)
        ///        {
        ///            Update((userView) =&gt;
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _002_ParenthesisLambda_FIXED {
            get {
                return ResourceManager.GetString("_002_ParenthesisLambda_FIXED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///
        ///namespace ConsoleApp9
        ///{
        ///    public class User
        ///    {
        ///        public int Id { get; set; }
        ///
        ///        public string Name { get; set; }
        ///
        ///        public string Tenant { get; set; }
        ///    }
        ///
        ///    public class UserView
        ///    {
        ///        public int Id { get; set; }
        ///
        ///        public string Name { get; set; }
        ///
        ///        public string Tenant { get; set; }
        ///    }
        ///
        ///    public static class Examples
        ///    {
        ///        public static void Process(User user)
        ///        {        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _003_GenericLambda {
            get {
                return ResourceManager.GetString("_003_GenericLambda", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///
        ///namespace ConsoleApp9
        ///{
        ///    public class User
        ///    {
        ///        public int Id { get; set; }
        ///
        ///        public string Name { get; set; }
        ///
        ///        public string Tenant { get; set; }
        ///    }
        ///
        ///    public class UserView
        ///    {
        ///        public int Id { get; set; }
        ///
        ///        public string Name { get; set; }
        ///
        ///        public string Tenant { get; set; }
        ///    }
        ///
        ///    public static class Examples
        ///    {
        ///        public static void Process(User user)
        ///        {        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _003_GenericLambda_FIXED {
            get {
                return ResourceManager.GetString("_003_GenericLambda_FIXED", resourceCulture);
            }
        }
    }
}
