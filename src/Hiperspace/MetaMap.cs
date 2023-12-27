// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Runtime.CompilerServices;

namespace Hiperspace
{
    /// <summary>
    /// Meta Map to process protobuf byte[] buffer tranform
    /// </summary>
    public struct MetaMap
    {
        private (int key, (int member, int key)[] values)[] _map;
        private (int member, int key)[] _currentMap;
        private int _current = 0;
        private Stack<(int key, int poppoint)> _stack;
        private int _popPoint;

        public MetaMap((int key, (int member, int key)[] values)[] map, int popPoint)
        {
            _map = map;
            _stack = new Stack<(int key, int poppoint)>(popPoint / 2);
            _currentMap = map[0].values;
            _popPoint = popPoint;
        }

        /// <summary>
        /// Push the history 
        /// </summary>
        /// <param name="key">id number of the element</param>
        /// <param name="poppoint">length of this node</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Push (int key, int poppoint)
        {
            int s = 0, e = _map.Length - 1, m = _map.Length / 2, ls = m, le = m;
            do
            {
                if (_map[s].key == key)
                {
                    _stack.Push((_current, _popPoint));
                    _currentMap = _map[s].values;
                    _current = _map[s].key;
                    _popPoint = poppoint;
                    return;
                }
                else if (_map[e].key == key)
                {
                    _stack.Push((_current, _popPoint));
                    _currentMap = _map[e].values;
                    _current = _map[e].key;
                    _popPoint = poppoint;
                    return;
                }
                else if (key >= _map[m].key)
                    s = m;
                else 
                    e = m;
                m = (s + e) / 2;
                if (s == ls && e == le)
                    break;
                else
                {
                    ls = s;
                    le = e;
                }
            }
            while (s != e);
            return;
        }

        /// <summary>
        /// Pop the stack if we're past the length of the curent node
        /// </summary>
        /// <param name="pos">position in the byte[] that we've reached</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PopIf (int pos)
        {
            while (pos >= _popPoint)
            {
                (_current, _popPoint) = _stack.Pop();
            }
        }

        /// <summary>
        /// process the next field within the node
        /// </summary>
        /// <param name="member">key of the field</param>
        /// <param name="poppoint">length of the current node</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Next (int member, int poppoint)
        {
            int s = 0, e = _currentMap.Length - 1, m = _currentMap.Length / 2, ls = m, le = m;
            do
            {
                if (_currentMap[s].member == member)
                {
                    Push(_currentMap[s].key, poppoint);
                    return true;
                }
                else if (_currentMap[e].member == member)
                {
                    Push(_currentMap[e].key, poppoint);
                    return true;
                }
                else if (member >= _currentMap[m].member)
                    s = m;
                else 
                    e = m;
                m = (s + e) / 2;
                if (s == ls && e == le)
                    break;
                else
                {
                    ls = s;
                    le = e;
                }
            }
            while (s != e);
            return false;
        }
    }
}
