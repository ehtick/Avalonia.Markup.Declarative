#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
<<<<<<< HEAD
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
=======
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.2.999.0")]
>>>>>>> c1347bc81bdb20ad44b1fda7d31eecec56065f2f
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class StyleBase_MarkupExtensions
{
//================= Events ======================//
 // OwnerChanged

/*ActionToEventGenerator*/
public static T OnOwnerChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Styling.StyleBase  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.OwnerChanged += h);



}
