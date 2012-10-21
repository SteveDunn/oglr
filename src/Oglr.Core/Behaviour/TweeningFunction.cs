using System;

namespace Oglr.Core.Behaviour
{
	public delegate float TweeningFunction( float timeElapsed, float start, float change, float duration ) ;
}