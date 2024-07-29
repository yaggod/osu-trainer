using FsBeatmapProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu_trainer.Extensions
{
	public static class GameModeExtension
	{
		public static decimal GetMaxOD(this GameMode mode)
		{
			switch (mode)
			{
				case GameMode.osu:
				case GameMode.Taiko:
				case GameMode.CatchtheBeat:
					return 11M;
				case GameMode.Mania:
				default:
					return 10M; // sounds incredible
				
			}
					

		}

		public static decimal GetMaxAR(this GameMode mode)
		{
			switch (mode)
			{
				case GameMode.osu:
				case GameMode.Taiko:
				case GameMode.CatchtheBeat:
					return 11M;
				case GameMode.Mania:
				default:
					return 10M; // to avoid issues with unnecessary DT difficulties

			}


		}
	}
}
