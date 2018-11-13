﻿/*
 * C# port BottomBar library for Android
 * Copyright (c) 2016 Iiro Krankka (http://github.com/roughike).
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace BottomNavigationBar.Listeners
{
	[Obsolete("Deprecated")]
	/// <summary>
	/// Deprecated, use <see cref="IOnTabClickListener"/>
	/// </summary>
    public interface IOnTabSelectedListener
    {
        /// <summary>
        /// The method being called when currently visible <see cref="BottomBarTab"/> changes.
        /// This listener won't be fired until the user changes the selected item the
        /// first time. So you won't get this event when you're just initialized the BottomBar.
        /// </summary>
        /// <param name="position">position the new visible <see cref="BottomBarTab"/>.</param>
        void OnItemSelected(int position);
    }
}

