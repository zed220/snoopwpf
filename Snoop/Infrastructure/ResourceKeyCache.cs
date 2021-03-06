﻿// (c) Copyright Cory Plotts.
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.

using System.Collections.Generic;

namespace Snoop.Infrastructure {
    public static class ResourceKeyCache {
        static readonly Dictionary<object, string> Keys = new Dictionary<object, string>();

        public static string GetKey(object element) {
            string key;
            if (Keys.TryGetValue(element, out key))
                return key;

            return null;
        }

        public static void Cache(object element, string key) {
            if (!Keys.ContainsKey(element)) {
                Keys.Add(element, key);
            }
        }

        public static bool Contains(object element) {
            return Keys.ContainsKey(element);
        }
    }
}