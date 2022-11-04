using System;

public class BallFactory : IToyFactory
{

	public Ball CreatNew()
    {
		return new Ball();

	}
}
