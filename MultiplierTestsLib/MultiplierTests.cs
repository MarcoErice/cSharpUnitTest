﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiplierTestsLib
{
    [TestClass]
    public class MultiplierTests
    {
        [TestMethod]
        public void Simple()
        {
            // Arrange
            MultiplierLib.Multiplier myMultiplier = new MultiplierLib.Multiplier();
            // Act
            var actual = myMultiplier.Simple(20, 20);
            // Assert
            Assert.AreEqual(400, actual);
        }
        [TestMethod]
        public void UsingFor()
        {
            // Arrange
            MultiplierLib.Multiplier myMultiplier = new MultiplierLib.Multiplier();
            // Act
            var actual = myMultiplier.UsingFor(20, 20);
            // Assert
            Assert.AreEqual(400, actual);
        }
        [TestMethod]
        public void UsingWhile()
        {
            // Arrange
            MultiplierLib.Multiplier myMultiplier = new MultiplierLib.Multiplier();
            // Act
            var actual = myMultiplier.UsingWhile(20, 20);
            // Assert
            Assert.AreEqual(400, actual);
        }
    }
}
