namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			for (int i = 0; i < width + height; i++)
            {
				if (!robot.Finished && robot.Y != height - 2)
				{
					robot.MoveTo(Direction.Down);
				}

				else if (!robot.Finished && robot.X != width - 2)
				{
					robot.MoveTo(Direction.Right);
				}
			}
		}	
	}
}