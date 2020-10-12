using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tellurian.Trains.Planning.App.Contract;
using Tellurian.Trains.Planning.App.Client.Services;
using System.Linq;

namespace App.Client.Tests
{
    [TestClass]
    public class GraphicScheduleExtensionsTests
    {
        private static readonly GraphicScheduleOptions Options = GraphicScheduleExtensions.Options;

        [TestMethod]
        public void FirstStationIsAtYoffset()
        {
            var target = Target;
            Assert.AreEqual(Options.Yoffset, target.YStation(target.Stations[0]));
        }

        [TestMethod]
        public void FirstStationHeightIsCorrect()
        {
            var target = Target;
            Assert.AreEqual(56, target.Stations[0].XHeight());
        }

        [TestMethod]
        public void SecondStationIsAtCorrectYoffset()
        {
            var target = Target;
            Assert.AreEqual(Options.Yoffset+ 56 + 50, target.YStation(target.Stations[1]));

        }

        private static TimetableStretch Target =>
            new TimetableStretch
            {
                Name = "Test",
                Number = "1a",
                Stations = new[]
                {
                    new TimetableStretchStation
                    {
                        DisplayOrder = 1,
                        DistanceFromPrevious=0,
                        Station = new Station
                        {
                            Id = 1,
                            Tracks = new []
                            {
                                new StationTrack { DisplayOrder = 1, IsScheduledTrack = true},
                                new StationTrack { DisplayOrder = 2, IsScheduledTrack = true},
                                new StationTrack { DisplayOrder = 3, IsScheduledTrack = true},
                                new StationTrack { DisplayOrder = 4, IsScheduledTrack = true},
                                new StationTrack { DisplayOrder = 5, IsScheduledTrack = true},
                                new StationTrack { DisplayOrder = 6, IsScheduledTrack = true},
                                new StationTrack { DisplayOrder = 7, IsScheduledTrack = true},
                                new StationTrack { DisplayOrder = 8, IsScheduledTrack = true}
                            }
                        }
                    },
                    new TimetableStretchStation
                    {
                        DisplayOrder = 2,
                        DistanceFromPrevious=5,
                        Station = new Station
                        {
                            Id = 2,
                            Tracks = new []
                            {
                                new StationTrack { DisplayOrder = 1, IsScheduledTrack = true}
                            }
                        }
                    },
                    new TimetableStretchStation
                    {
                        DisplayOrder = 3,
                        DistanceFromPrevious=3,
                        Station = new Station
                        {
                            Id = 3,
                            Tracks = new []
                            {
                                new StationTrack { DisplayOrder = 1, IsScheduledTrack = true},
                                new StationTrack { DisplayOrder = 2, IsScheduledTrack = true},
                                new StationTrack { DisplayOrder = 3, IsScheduledTrack = true}
                            }
                        }
                    },
                    new TimetableStretchStation
                    {
                        DisplayOrder = 4,
                        DistanceFromPrevious=7,
                        Station = new Station
                        {
                           Id = 4,
                           Tracks = new []
                            {
                                new StationTrack { DisplayOrder = 1, IsScheduledTrack = true},
                                new StationTrack { DisplayOrder = 2, IsScheduledTrack = true},
                                new StationTrack { DisplayOrder = 3, IsScheduledTrack = true}
                            }
                        }
                    }
                }
            };
    }
}
