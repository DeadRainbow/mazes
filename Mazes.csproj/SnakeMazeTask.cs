namespace Mazes
{
	public static class SnakeMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			for (int i = 1; i < (width * 8) + height; i++)
			{
				MoveToRightWall(robot, width, height);

				MoveToDownWall(robot, width, height);

				MoveToDownWall2(robot, width, height);

				MoveToLeftWall(robot, width, height);
			}
		}
		public static void MoveToRightWall(Robot robot, int width, int height)
        {
			if ((!robot.Finished && robot.X != width - 2) && (!robot.Finished && robot.Y == 13 || robot.Y == 9 || robot.Y == 5 || robot.Y == 1))
			{
				robot.MoveTo(Direction.Right);
			}
		}
		public static void MoveToDownWall(Robot robot, int width, int height)
        {
			if (!robot.Finished && ((robot.Y >= 1 && robot.Y < 3) || (robot.Y >= 5 && robot.Y < 7) || (robot.Y >= 9 && robot.Y < 11) || (robot.Y >= 13 && robot.Y < 15)) && (robot.X == width - 2))
			{
				robot.MoveTo(Direction.Down);
			}
		}
		public static void MoveToDownWall2(Robot robot, int width, int height)
		{
			if (!robot.Finished && ((robot.Y >= 3 && robot.Y < 5) || (robot.Y >= 7 && robot.Y < 9) || (robot.Y >= 11 && robot.Y < 13)) && (robot.X == 1))
			{
				robot.MoveTo(Direction.Down);
			}
		}

		public static void MoveToLeftWall(Robot robot, int width, int height)
		{
			if ((!robot.Finished && robot.X != 1) && (!robot.Finished && robot.Y == 15 || robot.Y == 11 || robot.Y == 7 || robot.Y == 3))
			{
				robot.MoveTo(Direction.Left);
			}
		}
	}
}
