using System;

namespace Billiards
{
    public static class BilliardsTask
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="directionRadians">Угол направелния движения шара</param>
        /// <param name="wallInclinationRadians">Угол</param>
        /// <returns></returns>
        public static double BounceWall(double directionRadians, double wallInclinationRadians)
        {
            double wallInclinationGradus = wallInclinationRadians * 180 / Math.PI;
            double directionGradus = directionRadians * 180 / Math.PI;
            double res = 2 * wallInclinationGradus - directionGradus;
            return res * Math.PI / 180;
        }
    }
}