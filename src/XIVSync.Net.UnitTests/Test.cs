using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace XIVSync.Net.UnitTests
{

    [TestFixture]
    public class Test
    {
        //TODO make real unit tests not really "does this work tests"
        [Test]
        public void DoesSearchWork()
        {
            var api = new LodestoneApi();
            var res = api.SearchCharacter("Lucia Yokoyama", "Midgardsormr");
            Assert.AreEqual(res.Ok, 1);
            res = new LodestoneApi().SearchCharacter("Karalix Velatin", "Midgardsormr");
            Assert.AreEqual(res.Ok, 1);
        }

        [Test]
        public void DoesGetCharacterWork()
        {
            var res = new LodestoneApi().GetCharacter("8696200");
            Assert.AreEqual(res.Ok, 1);
            res = new LodestoneApi().GetCharacter("8555950");
            Assert.AreEqual(res.Ok, 1);

        }
    }
}
