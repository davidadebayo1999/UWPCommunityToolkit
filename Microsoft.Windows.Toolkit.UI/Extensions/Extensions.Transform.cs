﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Microsoft.Toolkit.Uwp.UI
{
    /// <summary>
    /// Defines a collection of extensions methods for UI.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        /// Gets the current X translation of a <see cref="FrameworkElement"/>.
        /// </summary>
        /// <param name="frameworkElement">
        /// The <see cref="FrameworkElement"/>.
        /// </param>
        /// <returns>
        /// Returns the X translation.
        /// </returns>
        public static double GetTranslateX(this FrameworkElement frameworkElement)
        {
            return frameworkElement.GetCompositeTransform().TranslateX;
        }

        /// <summary>
        /// Gets the current Y translation of a <see cref="FrameworkElement"/>.
        /// </summary>
        /// <param name="frameworkElement">
        /// The <see cref="FrameworkElement"/>.
        /// </param>
        /// <returns>
        /// Returns the Y translation.
        /// </returns>
        public static double GetTranslateY(this FrameworkElement frameworkElement)
        {
            return frameworkElement.GetCompositeTransform().TranslateY;
        }

        /// <summary>
        /// Translates a <see cref="FrameworkElement"/> on the X axis to the provided X value.
        /// </summary>
        /// <param name="frameworkElement">
        /// The <see cref="FrameworkElement"/>.
        /// </param>
        /// <param name="x">
        /// The value to translate to on the X axis.
        /// </param>
        public static void TranslateX(this FrameworkElement frameworkElement, double x)
        {
            frameworkElement.GetCompositeTransform().TranslateX = x;
        }

        /// <summary>
        /// Translates a <see cref="FrameworkElement"/> on the Y axis to the provided Y value.
        /// </summary>
        /// <param name="frameworkElement">
        /// The <see cref="FrameworkElement"/>.
        /// </param>
        /// <param name="y">
        /// The value to translate to on the Y axis.
        /// </param>
        public static void TranslateY(this FrameworkElement frameworkElement, double y)
        {
            frameworkElement.GetCompositeTransform().TranslateY = y;
        }

        /// <summary>
        /// Translates a <see cref="FrameworkElement"/> on the X axis by the provided X value.
        /// </summary>
        /// <param name="frameworkElement">
        /// The <see cref="FrameworkElement"/>.
        /// </param>
        /// <param name="x">
        /// The value to translate by on the X axis.
        /// </param>
        public static void TranslateDeltaX(this FrameworkElement frameworkElement, double x)
        {
            frameworkElement.GetCompositeTransform().TranslateX += x;
        }

        /// <summary>
        /// Translates a <see cref="FrameworkElement"/> on the Y axis by the provided Y value.
        /// </summary>
        /// <param name="frameworkElement">
        /// The <see cref="FrameworkElement"/>.
        /// </param>
        /// <param name="y">
        /// The value to translate by on the Y axis.
        /// </param>
        public static void TranslateDeltaY(this FrameworkElement frameworkElement, double y)
        {
            frameworkElement.GetCompositeTransform().TranslateY += y;
        }

        /// <summary>
        /// Gets the composite transform for a <see cref="FrameworkElement"/>.
        /// </summary>
        /// <param name="frameworkElement">
        /// The <see cref="FrameworkElement"/>.
        /// </param>
        /// <returns>
        /// Returns a <see cref="CompositeTransform"/> representation for the given element.
        /// </returns>
        public static CompositeTransform GetCompositeTransform(this FrameworkElement frameworkElement)
        {
            var transform = frameworkElement.RenderTransform as CompositeTransform;
            if (transform == null)
            {
                transform = new CompositeTransform();
                frameworkElement.RenderTransform = transform;
            }

            return transform;
        }
    }
}