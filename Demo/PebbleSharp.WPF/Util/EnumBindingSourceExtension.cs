using Avalonia.Markup.Xaml;

namespace PebbleSharp.WPF.Util;

internal sealed class EnumBindingSourceExtension : MarkupExtension
{
    public Type EnumType { get; private set; } = null!;

    public EnumBindingSourceExtension(Type enumType)
    {
        if (enumType is null || !enumType.IsEnum)
            return;

        EnumType = enumType;
    }

    public override object ProvideValue(IServiceProvider serviceProvider) => Enum.GetValues(EnumType);
}