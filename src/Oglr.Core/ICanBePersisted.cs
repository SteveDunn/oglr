using System;
using System.Xml.Linq;

namespace Oglr.Core
{
	public interface ICanBePersisted
	{
		XElement ToXml( ) ;
	}
}