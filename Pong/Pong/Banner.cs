using System;
using System.Collections.Generic;
using System.Text;

namespace banner
{
    /// <summary>
    /// Description of Banner.
    /// </summary>
    internal static class Banner
    {
        /// <summary>
        /// Creates the text banner
        /// </summary>
        /// <param name="bannerText">The text to be displayed</param>
        /// <param name="bannerChar">The character used to create the banner</param>
        /// <param name="space">The text between words</param>
        /// <param name="sep">The text between characters in the same word</param>
        /// <param name="italic">Is the banner in italic or not</param>
        /// <returns>Returns a string containing the banner</returns>
        public static string CreateBanner(string bannerText, string bannerChar, string space, string sep, bool italic)
        {
            int D;
            int F;
            string[] Banner = new string[8];

            bannerText = bannerText.ToLower();

            for (F = 0; F <= 6; F++)
            {
                for (D = 0; D <= (bannerText.Length - 1); D++)
                {
                    switch (bannerText[D].ToString())
                    {
                        case " ":
                            Banner[F] += sep;
                            break;

                        case "a":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += sep + sep + sep + bannerChar + sep + sep + sep;
                                    break;
                                case 1:
                                    Banner[F] += sep + sep + bannerChar + sep + bannerChar + sep + sep;
                                    break;
                                case 2:
                                    Banner[F] += sep + bannerChar + sep + sep + sep + bannerChar + sep;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 4:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 6:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                            }
                            break;

                        case "b":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                                case 4:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 6:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                            }
                            break;

                        case "c":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + sep;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + sep;
                                    break;
                                case 4:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + sep;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 6:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                            }
                            break;

                        case "d":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 4:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 6:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                            }
                            break;

                        case "e":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + sep;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + sep;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + sep + sep;
                                    break;
                                case 4:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + sep;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + sep;
                                    break;
                                case 6:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar;
                                    break;
                            }
                            break;

                        case "f":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + sep;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + sep;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + sep + sep;
                                    break;
                                case 4:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + sep;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + sep;
                                    break;
                                case 6:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + sep;
                                    break;
                            }
                            break;

                        case "g":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + sep;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + sep + sep + bannerChar + bannerChar + bannerChar + bannerChar;
                                    break;
                                case 4:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 6:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                            }
                            break;

                        case "h":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar;
                                    break;
                                case 4:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 6:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                            }
                            break;

                        case "i":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += bannerChar + bannerChar + bannerChar;
                                    break;
                                case 1:
                                    Banner[F] += sep + bannerChar + sep;
                                    break;
                                case 2:
                                    Banner[F] += sep + bannerChar + sep;
                                    break;
                                case 3:
                                    Banner[F] += sep + bannerChar + sep;
                                    break;
                                case 4:
                                    Banner[F] += sep + bannerChar + sep;
                                    break;
                                case 5:
                                    Banner[F] += sep + bannerChar + sep;
                                    break;
                                case 6:
                                    Banner[F] += bannerChar + bannerChar + bannerChar;
                                    break;
                            }
                            break;

                        case "j":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += sep + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 1:
                                    Banner[F] += sep + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += sep + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 3:
                                    Banner[F] += sep + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 4:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 6:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                            }
                            break;

                        case "k":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + bannerChar + sep;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + bannerChar + sep + sep;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + sep + sep + sep;
                                    break;
                                case 4:
                                    Banner[F] += bannerChar + sep + sep + bannerChar + sep + sep;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + sep + bannerChar + sep;
                                    break;
                                case 6:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + bannerChar;
                                    break;
                            }
                            break;

                        case "l":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + sep;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + sep;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + sep;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + sep;
                                    break;
                                case 4:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + sep;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + sep;
                                    break;
                                case 6:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar;
                                    break;
                            }
                            break;

                        case "m":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + bannerChar + sep + sep + sep + bannerChar + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + bannerChar + sep + bannerChar + sep + bannerChar;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + sep + sep + bannerChar + sep + sep + bannerChar;
                                    break;
                                case 4:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 6:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                            }
                            break;

                        case "n":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + bannerChar + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + bannerChar + sep + sep + sep + bannerChar;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + sep + sep + bannerChar + sep + sep + bannerChar;
                                    break;
                                case 4:
                                    Banner[F] += bannerChar + sep + sep + sep + bannerChar + sep + bannerChar;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + bannerChar + bannerChar;
                                    break;
                                case 6:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                            }
                            break;

                        case "o":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 4:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 6:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar;
                                    break;
                            }
                            break;

                        case "p":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                                case 4:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + sep;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + sep;
                                    break;
                                case 6:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + sep;
                                    break;
                            }
                            break;

                        case "q":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 4:
                                    Banner[F] += bannerChar + sep + sep + sep + bannerChar + sep + bannerChar;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + bannerChar + sep;
                                    break;
                                case 6:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + bannerChar + sep + bannerChar;
                                    break;
                            }
                            break;

                        case "r":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                                case 4:
                                    Banner[F] += bannerChar + sep + sep + sep + bannerChar + sep + sep;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + bannerChar + sep;
                                    break;
                                case 6:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                            }
                            break;

                        case "s":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + sep;
                                    break;
                                case 3:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                                case 4:
                                    Banner[F] += sep + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 6:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                            }
                            break;

                        case "t":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar;
                                    break;
                                case 1:
                                    Banner[F] += sep + sep + sep + bannerChar + sep + sep + sep;
                                    break;
                                case 2:
                                    Banner[F] += sep + sep + sep + bannerChar + sep + sep + sep;
                                    break;
                                case 3:
                                    Banner[F] += sep + sep + sep + bannerChar + sep + sep + sep;
                                    break;
                                case 4:
                                    Banner[F] += sep + sep + sep + bannerChar + sep + sep + sep;
                                    break;
                                case 5:
                                    Banner[F] += sep + sep + sep + bannerChar + sep + sep + sep;
                                    break;
                                case 6:
                                    Banner[F] += sep + sep + sep + bannerChar + sep + sep + sep;
                                    break;
                            }
                            break;

                        case "u":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 4:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 6:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                            }
                            break;

                        case "v":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 4:
                                    Banner[F] += sep + bannerChar + sep + sep + sep + bannerChar + sep;
                                    break;
                                case 5:
                                    Banner[F] += sep + sep + bannerChar + sep + bannerChar + sep + sep;
                                    break;
                                case 6:
                                    Banner[F] += sep + sep + sep + bannerChar + sep + sep + sep;
                                    break;
                            }
                            break;

                        case "w":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + bannerChar + sep + sep + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + bannerChar + sep + sep + bannerChar;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + sep + sep + bannerChar + sep + sep + bannerChar;
                                    break;
                                case 4:
                                    Banner[F] += bannerChar + sep + sep + bannerChar + sep + sep + bannerChar;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + bannerChar + sep + sep + bannerChar;
                                    break;
                                case 6:
                                    Banner[F] += sep + bannerChar + bannerChar + sep + bannerChar + bannerChar + sep;
                                    break;
                            }
                            break;

                        case "x":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 1:
                                    Banner[F] += sep + bannerChar + sep + sep + sep + bannerChar + sep;
                                    break;
                                case 2:
                                    Banner[F] += sep + sep + bannerChar + sep + bannerChar + sep + sep;
                                    break;
                                case 3:
                                    Banner[F] += sep + sep + sep + bannerChar + sep + sep + sep;
                                    break;
                                case 4:
                                    Banner[F] += sep + sep + bannerChar + sep + bannerChar + sep + sep;
                                    break;
                                case 5:
                                    Banner[F] += sep + bannerChar + sep + sep + sep + bannerChar + sep;
                                    break;
                                case 6:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                            }
                            break;

                        case "y":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 1:
                                    Banner[F] += sep + bannerChar + sep + sep + sep + bannerChar + sep;
                                    break;
                                case 2:
                                    Banner[F] += sep + sep + bannerChar + sep + bannerChar + sep + sep;
                                    break;
                                case 3:
                                    Banner[F] += sep + sep + sep + bannerChar + sep + sep + sep;
                                    break;
                                case 4:
                                    Banner[F] += sep + sep + sep + bannerChar + sep + sep + sep;
                                    break;
                                case 5:
                                    Banner[F] += sep + sep + sep + bannerChar + sep + sep + sep;
                                    break;
                                case 6:
                                    Banner[F] += sep + sep + sep + bannerChar + sep + sep + sep;
                                    break;
                            }
                            break;

                        case "z":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar;
                                    break;
                                case 1:
                                    Banner[F] += sep + sep + sep + sep + sep + bannerChar + sep;
                                    break;
                                case 2:
                                    Banner[F] += sep + sep + sep + sep + bannerChar + sep + sep;
                                    break;
                                case 3:
                                    Banner[F] += sep + sep + sep + bannerChar + sep + sep + sep;
                                    break;
                                case 4:
                                    Banner[F] += sep + sep + bannerChar + sep + sep + sep + sep;
                                    break;
                                case 5:
                                    Banner[F] += sep + bannerChar + sep + sep + sep + sep + sep;
                                    break;
                                case 6:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar + bannerChar;
                                    break;
                            }
                            break;

                        case "1":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += sep + sep + bannerChar + sep + sep;
                                    break;
                                case 1:
                                    Banner[F] += sep + bannerChar + bannerChar + sep + sep;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + bannerChar + sep + sep;
                                    break;
                                case 3:
                                    Banner[F] += sep + sep + bannerChar + sep + sep;
                                    break;
                                case 4:
                                    Banner[F] += sep + sep + bannerChar + sep + sep;
                                    break;
                                case 5:
                                    Banner[F] += sep + sep + bannerChar + sep + sep;
                                    break;
                                case 6:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar;
                                    break;
                            }
                            break;

                        case "2":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + sep + bannerChar;
                                    break;
                                case 3:
                                    Banner[F] += sep + sep + sep + bannerChar + sep;
                                    break;
                                case 4:
                                    Banner[F] += sep + sep + bannerChar + sep + sep;
                                    break;
                                case 5:
                                    Banner[F] += sep + bannerChar + sep + sep + sep;
                                    break;
                                case 6:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar;
                                    break;
                            }
                            break;

                        case "3":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += sep + sep + sep + sep + bannerChar;
                                    break;
                                case 3:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                                case 4:
                                    Banner[F] += sep + sep + sep + sep + bannerChar;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + sep + bannerChar;
                                    break;
                                case 6:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                            }
                            break;

                        case "4":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += bannerChar + sep + sep + sep + bannerChar;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + sep + bannerChar;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar;
                                    break;
                                case 4:
                                    Banner[F] += sep + sep + sep + sep + bannerChar;
                                    break;
                                case 5:
                                    Banner[F] += sep + sep + sep + sep + bannerChar;
                                    break;
                                case 6:
                                    Banner[F] += sep + sep + sep + sep + bannerChar;
                                    break;
                            }
                            break;

                        case "5":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + sep;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + sep + sep;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar;
                                    break;
                                case 4:
                                    Banner[F] += sep + sep + sep + sep + bannerChar;
                                    break;
                                case 5:
                                    Banner[F] += sep + sep + sep + sep + bannerChar;
                                    break;
                                case 6:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar;
                                    break;
                            }
                            break;

                        case "6":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + sep + sep;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                                case 4:
                                    Banner[F] += bannerChar + sep + sep + sep + bannerChar;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + sep + bannerChar;
                                    break;
                                case 6:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                            }
                            break;

                        case "7":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar;
                                    break;
                                case 1:
                                    Banner[F] += sep + sep + sep + sep + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += sep + sep + sep + bannerChar + sep;
                                    break;
                                case 3:
                                    Banner[F] += sep + sep + bannerChar + sep + sep;
                                    break;
                                case 4:
                                    Banner[F] += sep + bannerChar + sep + sep + sep;
                                    break;
                                case 5:
                                    Banner[F] += sep + bannerChar + sep + sep + sep;
                                    break;
                                case 6:
                                    Banner[F] += sep + bannerChar + sep + sep + sep;
                                    break;
                            }
                            break;

                        case "8":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + sep + bannerChar;
                                    break;
                                case 3:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                                case 4:
                                    Banner[F] += bannerChar + sep + sep + sep + bannerChar;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + sep + bannerChar;
                                    break;
                                case 6:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                            }
                            break;

                        case "9":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + sep + bannerChar;
                                    break;
                                case 3:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                                case 4:
                                    Banner[F] += sep + sep + sep + bannerChar + sep;
                                    break;
                                case 5:
                                    Banner[F] += sep + sep + bannerChar + sep + sep;
                                    break;
                                case 6:
                                    Banner[F] += sep + bannerChar + sep + sep + sep;
                                    break;
                            }
                            break;

                        case "0":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                                case 1:
                                    Banner[F] += bannerChar + sep + sep + sep + bannerChar + bannerChar;
                                    break;
                                case 2:
                                    Banner[F] += bannerChar + sep + sep + bannerChar + sep + bannerChar;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + sep + bannerChar + sep + sep + bannerChar;
                                    break;
                                case 4:
                                    Banner[F] += bannerChar + bannerChar + sep + sep + sep + bannerChar;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + sep + sep + sep + sep + bannerChar;
                                    break;
                                case 6:
                                    Banner[F] += sep + bannerChar + bannerChar + bannerChar + bannerChar + sep;
                                    break;
                            }
                            break;

                        case "-":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += sep + sep + sep + sep + sep;
                                    break;
                                case 1:
                                    Banner[F] += sep + sep + sep + sep + sep;
                                    break;
                                case 2:
                                    Banner[F] += sep + sep + sep + sep + sep;
                                    break;
                                case 3:
                                    Banner[F] += bannerChar + bannerChar + bannerChar + bannerChar + bannerChar;
                                    break;
                                case 4:
                                    Banner[F] += sep + sep + sep + sep + sep;
                                    break;
                                case 5:
                                    Banner[F] += sep + sep + sep + sep + sep;
                                    break;
                                case 6:
                                    Banner[F] += sep + sep + sep + sep + sep;
                                    break;
                            }
                            break;

                        case ":":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += sep + sep + sep + sep + sep;
                                    break;
                                case 1:
                                    Banner[F] += sep + sep + sep + sep + sep;
                                    break;
                                case 2:
                                    Banner[F] += sep + sep + bannerChar + sep + sep;
                                    break;
                                case 3:
                                    Banner[F] += sep + sep + sep + sep + sep;
                                    break;
                                case 4:
                                    Banner[F] += sep + sep + sep + sep + sep;
                                    break;
                                case 5:
                                    Banner[F] += sep + sep + bannerChar + sep + sep;
                                    break;
                                case 6:
                                    Banner[F] += sep + sep + sep + sep + sep;
                                    break;
                            }
                            break;

                        case ".":
                            switch (F)
                            {
                                case 0:
                                    Banner[F] += sep + sep + sep;
                                    break;
                                case 1:
                                    Banner[F] += sep + sep + sep;
                                    break;
                                case 2:
                                    Banner[F] += sep + sep + sep;
                                    break;
                                case 3:
                                    Banner[F] += sep + sep + sep;
                                    break;
                                case 4:
                                    Banner[F] += sep + sep + sep;
                                    break;
                                case 5:
                                    Banner[F] += bannerChar + bannerChar + bannerChar;
                                    break;
                                case 6:
                                    Banner[F] += bannerChar + bannerChar + bannerChar;
                                    break;
                            }
                            break;
                    }
                    Banner[F] += space;
                }
            }

            if (italic)
            {
                int tilt = 6;

                for (int x = 0; x < Banner.Length; x++)
                {
                    for (int y = 0; y < tilt; y++)
                    {
                        Banner[x] = " " + Banner[x];
                    }

                    tilt--;
                }
            }

            return "\n" + string.Join("\n", Banner);
        }
    }
}
