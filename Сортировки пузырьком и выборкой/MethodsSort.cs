using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сортировки_пузырьком_и_выборкой
{
    class MethodsSequience
    {
        public int startRange { get; set; }
        public int endRange { get; set; }
        public int startPosition { get; set; }
        public MethodsSort methodsSort { get; set; }

        public MethodsSequience(int startRange, int endRange, int startPosition, MethodsSort methodsSort)
        {
            this.startRange = startRange;
            this.endRange = endRange;
            this.methodsSort = methodsSort;
        }
    }
}
