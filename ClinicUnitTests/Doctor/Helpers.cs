using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Przychodnia.Class.Login;
using Xunit;

namespace ClinicUnitTests.Doctor
{
    public class Helpers
    {
        [Fact]
        public void TestGenerateHours()
        {
            //Arange
            List<TimeSpan> expectedListofGenerateHours = new List<TimeSpan>() { new TimeSpan(7, 0, 0), new TimeSpan(7, 15, 0), new TimeSpan(7, 30, 0), new TimeSpan(7, 45, 0), new TimeSpan(8, 0, 0),
            new TimeSpan(8, 15, 0), new TimeSpan(8, 30, 0), new TimeSpan(8, 45, 0), new TimeSpan(9, 0, 0), new TimeSpan(9, 15, 0),new TimeSpan(9, 30, 0), new TimeSpan(9, 45, 0), new TimeSpan(10, 0, 0), new TimeSpan(10, 15, 0), new TimeSpan(10, 30, 0), new TimeSpan(10, 45, 0), new TimeSpan(11, 0, 0), new TimeSpan(11, 15, 0), new TimeSpan(11, 30, 0), new TimeSpan(11, 45, 0), new TimeSpan(12, 0, 0), new TimeSpan(12, 15, 0), new TimeSpan(12, 30, 0), new TimeSpan(12, 45, 0), new TimeSpan(13, 0, 0), new TimeSpan(13, 15, 0), new TimeSpan(13, 30, 0), new TimeSpan(13, 45, 0), new TimeSpan(14, 0, 0), new TimeSpan(14, 15, 0), new TimeSpan(14, 30, 0), new TimeSpan(14, 45, 0), new TimeSpan(15, 0, 0), new TimeSpan(15, 15, 0), new TimeSpan(15, 30, 0),new TimeSpan(15, 45, 0), new TimeSpan(16, 0, 0), new TimeSpan(16, 15, 0), new TimeSpan(16, 30, 0), new TimeSpan(16, 45, 0), new TimeSpan(17, 0, 0), new TimeSpan(17, 15, 0), new TimeSpan(17, 30, 0), new TimeSpan(17, 45, 0), new TimeSpan(18, 0, 0), new TimeSpan(18, 15, 0), new TimeSpan(18, 30, 0), new TimeSpan(18, 45, 0), new TimeSpan(19, 0, 0), new TimeSpan(19, 15, 0), new TimeSpan(19, 30, 0), new TimeSpan(19, 45, 0), new TimeSpan(20, 0, 0)
            };

            // Act
            List<TimeSpan> actualListofGenerateHours = ClassHelpers.GenerateListOfHours(new TimeSpan(7, 0, 0), new TimeSpan(20, 0, 0));

            // Assert
            Assert.Equal(expectedListofGenerateHours, actualListofGenerateHours);
        }

    }
}
