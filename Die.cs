﻿using System;

namespace CMP1903_A2_2324 {

  /// <summary>
  /// This class is designed to be simulate a normal 6-sided die.
  /// </summary>
  public class Die {

    /// <value>
    /// A static instance of the Random object to create random values for the class.
    /// </value>
    /// <remarks>
    /// By having the <c>Random</c> object being a static field, we can avoid the potential issue
    /// of some <c>Die</c> objects having the same seed for randomness when created sequentially.
    /// </remarks>
    private static readonly Random _random = new Random();

    public int NumberOfSides { get; private set; }

    /// <value>
    /// The <c>Value</c> property is used to access the side the dice is displaying.
    /// </value>
    public int Value { get; private set; }

    /// <value>
    /// The <c>Locked</c> property is used to prevent a die from being rolled.
    /// </value>
    public bool Locked { get; set; } = false;

    /// <summary>
    /// Create constructor that allows for the setting of the number of sides on the die.
    /// </summary>
    /// <param name="numberOfSides">
    /// Represents the number of sides that the die will have.
    /// Defaults to 6.
    /// </param>
    public Die(int numberOfSides = 6) {
      this.Value = _random.Next(1, NumberOfSides + 1);
      this.NumberOfSides = numberOfSides;
    }

    /// <summary>
    /// Simulates the action of rolling a die.
    /// </summary>
    /// <returns>
    /// An integer of the side the die displayed once rolled.
    /// </returns>
    public int Roll() {
      if (!Locked) {
        Value = _random.Next(1, NumberOfSides + 1);
      }
      return Value;
    }

    /// <summary>
    /// Overrides the default ToString method to return the die's value.
    /// </summary>
    /// <returns>
    /// A string containing the die's current value.
    /// </returns>
    public override string ToString() {
      return this.Value.ToString();
    }

  }
}
