// <copyright file="EffectTypeAttribute.cs" company="Corale">
//     Copyright © 2015 by Adam Hellberg and Brandon Scott.
//
//     Permission is hereby granted, free of charge, to any person obtaining a copy of
//     this software and associated documentation files (the "Software"), to deal in
//     the Software without restriction, including without limitation the rights to
//     use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
//     of the Software, and to permit persons to whom the Software is furnished to do
//     so, subject to the following conditions:
//
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
//
//     THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//     IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//     AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
//     WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
//     CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
//     "Razer" is a trademark of Razer USA Ltd.
// </copyright>

namespace Corale.Colore.Razer
{
    using System;

    using KeyboardEffects = Corale.Colore.Razer.Keyboard.Effects.Effect;

    /// <summary>
    /// Gives information about the type of effect an effect struct describes.
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct)]
    internal sealed class EffectTypeAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EffectTypeAttribute" /> class.
        /// </summary>
        /// <param name="effect">The general effect to construct from.</param>
        internal EffectTypeAttribute(Effect effect)
        {
            Value = (int)effect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectTypeAttribute" /> class.
        /// </summary>
        /// <param name="effect">The keyboard effect to construct from.</param>
        internal EffectTypeAttribute(KeyboardEffects effect)
        {
            Value = (int)effect;
        }

        /// <summary>
        /// Gets the integer value of the effect type.
        /// </summary>
        internal int Value { get; }
    }
}
