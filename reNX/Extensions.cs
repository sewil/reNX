// reNX is copyright angelsl, 2011 to 2015 inclusive.
// 
// This file (Extensions.cs) is part of reNX.
// 
// reNX is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// reNX is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with reNX. If not, see <http://www.gnu.org/licenses/>.
// 
// Linking reNX statically or dynamically with other modules
// is making a combined work based on reNX. Thus, the terms and
// conditions of the GNU General Public License cover the whole combination.
// 
// As a special exception, the copyright holders of reNX give you
// permission to link reNX with independent modules to produce an
// executable, regardless of the license terms of these independent modules,
// and to copy and distribute the resulting executable under terms of your
// choice, provided that you also meet, for each linked independent module,
// the terms and conditions of the license of that module. An independent
// module is a module which is not derived from or based on reNX.

using reNX.NXProperties;

namespace reNX
{
    public static class Extensions
    {
        public static bool TryGetValue(this NXNode node, string key, out NXNode value)
        {
            value = null;
            bool found = node.ContainsChild(key);
            if (found)
            {
                value = node[key];
            }
            return found;
        }
    }
}
