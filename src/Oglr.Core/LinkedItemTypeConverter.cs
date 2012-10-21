using System;
using System.ComponentModel;
using System.Globalization;
using Oglr.InGame;

namespace Oglr.Core
{
	public class LinkedItemTypeConverter : TypeConverter
	{
		public override bool CanConvertTo(ITypeDescriptorContext context, System.Type destinationType)
		{
			if (destinationType == typeof(LinkedItem))
			{
				return true;
			}

			return base.CanConvertTo(context, destinationType);
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType)
		{
			if (destinationType == typeof(string) && value is LinkedItem)
			{
				var result = (LinkedItem)value;
				return result.Name;
			}
			
			return base.ConvertTo(context, culture, value, destinationType);
		}
	}
}