﻿using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
//JaJuan Webster
//Professor Maier
//HW3: Relay Race

namespace Racers {


    /// <summary>
    /// A Racer on a RaceTrack. Runs from a starting position to an end point on its own thread.
    /// <list type="bullet">
    /// <item>
    /// <term>Authors:</term>
    /// <description>Sela Davis</description>
    /// <description>Dave Schwartz</description>
    /// <term>Fixed By:</term>
    /// <description>Kevin Bierre</description>
    /// </item>
    /// </list>
    /// </summary>
    public class Racer {

        #region fields

        private int xPos;                       // horizontal position of this racer
        private Thread prev;                    // thread of previous "teammate" racer
        private bool lastRunner;                // is this the last runner?
        private int distance;                   // how far the racer needs to go until tags next racer
        private int speed;                      // amount of pixels to move every hop
        private int sleep;                      // amount of time between hops
        private int track;                      // the track the racer is on
        private const int TIMEBUFFER = 30;      // time buffer used so random # generators do not seed with the same number (ms)
        private const int MINSPEED = 5;         // always want to move forward
        private const int MAXSPEED = 21;        // maximum speed of Racer
        private const int MINSLEEP = 200;       // min time between hops
        private const int MAXSLEEP = 501;       // max time between hops
        private RaceTrack raceTrack;            // reference to complete race track
        private Random rng;                    // Random number generator
        private int endPoint;                   // ending x value

        /// <summary>
        /// Access whether or not this Racer is the last on the team.
        /// </summary>
        public bool LastRunner
        {
            get { return lastRunner; }
            set { lastRunner = value; }
        }

        /// <summary>
        /// Access current horizontal position of this Racer.
        /// </summary>
        public int X
        {
            get { return xPos; }
            set { xPos = value; }
        }

        #endregion

        #region contructor

        /// <summary>
        /// Make a Racer given a horizontal position and how far to move.
        /// </summary>
        /// <param name="tracknumber">track number (starts at 0)</param>
        /// <param name="xPos">initial horizontal position on track</param>
        /// <param name="distanceToTravel">how far to move in track until reaching next Racer or finish</param>
        public Racer(RaceTrack rt, int tracknumber, int xPos, int distanceToTravel)
        {
            //Parameter instantiation
            raceTrack = rt;
            track = tracknumber;
            this.xPos = xPos;
            distance = distanceToTravel;

            //Random object with timebuffer to change the random seed
            rng = new Random();
            Thread.Sleep(TIMEBUFFER);

            //Random time step and distance traveled
            sleep = rng.Next(MINSLEEP, MAXSLEEP);
            speed = rng.Next(MINSPEED, MAXSPEED);

            //Endpoint for the racer
            endPoint = this.xPos + distance;
        } // constructor Racer

        #endregion

        #region racing

        /// <summary>
        /// Temporary move method (need to fix):
        /// </summary>
        public void move()
        {
            //if the previous thread is not null and the xPos is >= to the distance
            //the racer needs to travel, then join the threads. 
            if (prev != null && xPos >= distance)
            {
                prev.Join();
            }

            //while xPos is > endPoint
            while (xPos < endPoint)
            {
                Thread.Sleep(sleep);
                xPos += speed;
            }

            //if lastRunner is true, then end the race; call raceComplete
            if (lastRunner == true)
            {
                raceTrack.raceComplete(track);
            }
        }

        /// <summary>
        /// Prepares the racer to go when the previous racer is finished ("tagging off").
        /// </summary>
        /// <param name="previousRaceThread">The thread to join--aka the racer who will tag this one</param>
        public void follow(Thread previousRaceThread)
        {
            prev = previousRaceThread;
        }
        #endregion

    } // class Racer

} // namespace Racers