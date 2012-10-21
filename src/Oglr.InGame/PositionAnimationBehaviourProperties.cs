using System;
using Microsoft.Xna.Framework;
using Oglr.InGame.Interpolation;

namespace Oglr.InGame
{
	public class PositionAnimationBehaviourProperties : BehaviourProperties
	{
		public string NameOfPropertyToModify
		{
			get;
			set ;
		}

		public Vector2 From
		{
			get ;
			set ;
		}

		public Vector2 To
		{
			get ;
			set ;
		}

		public string ClrTypeOfInterpolator
		{
			get ;
			set ;
		}

		public Easing Easing
		{
			get ;
			set ;
		}

		public float DurationInSeconds
		{
			get ;
			set ;
		}
	}
}