﻿using System;
using System.Collections;

namespace general
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            Program programObject = new Program();

            // programObject.CalculateMaxProfit();

            // programObject.CalculateMaxDifference();

            // programObject.CalculateMinDiceThrowsSnakeAndLadders();           

            // programObject.SubstringOccurranceInStringM();

            // programObject.FibonacciM();

            // programObject.BinarySearchM();

            // programObject.PerfectSquareM();

            // programObject.TreeTraversalsM();

            // programObject.ConstructTreeFromTraversalsM();

            // programObject.TowerOfHanoiM();

            // programObject.MaxSumPathFromRootM();

            // programObject.RootToLeafSumM();

            // programObject.SubArrayWithSumGreaterThanNumberM();

            // programObject.LengthOfLongestPalindromicSubStringM();

            // programObject.LongestPalindromicSubStringM(); 

            // programObject.AllPossibleCombinationsOfElementsM();

            // programObject.DuplicateInArrayM();

            // programObject.SubSetSumEqualsNumArrayM();

            // programObject.SpiralPrintingOfBinaryTreeM();

            // programObject.LowestCommonAncestorBinaryTreeM();

            // programObject.DiameterOfBinaryTreeM();

            // programObject.PairOfNumbersEqualsSumM();

            // programObject.ProductArrayM();

            // programObject.BSTFromPreorderTraversalM();

            // programObject.SerializeDeSerializeBinaryTreeM();

            // programObject.SmallestPositiveNumberM();

            // programObject.PossibleDecodingDP();

            // programObject.MaxSumNonAdjacentM();

            // programObject.AutoCompletionUsingTrieM();

            // programObject.ClimbingStaircaseM();

            // programObject.LongestDistinctSubstringM();

            // programObject.IslandsInGraphM();

            // programObject.MinPlatformsRequiredM();

            // programObject.NQueenProblemM();

            // programObject.FindItineraryM();

            // programObject.SudocuM();

            // programObject.SlidingWindowMaximumM();

            // programObject.PaintingFenceM();

            // programObject.IntersectionPointLinkedListM();

            // programObject.WordBreakM();

            // programObject.InfixExpressionEvaluationM();

            // programObject.SortedSquaredArrayM();

            // programObject.rotatingMatrixM();

            _HeapSort();

            // To Do problems:
            // Addition in a linked list
            // Solve the registration (user name) problem using Trie
            // A chapter dependent on another chapter
            // Highway banner
            // Reverse words in a sentence
            // Expression evaluation using bodmas, stacks
            // Max subarray of adjacent numbers in an array
        }

        public void rotatingMatrixM(){
            RotatingMatrix rotatingMatrix = new RotatingMatrix();
            int [,] input = new int[,] {{ 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9}};
            for (int i = 0; i < input.GetLength(0); i++) {
                for (int j = 0; j < input.GetLength(1); j++) {
                    Console.Write(input[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n\n");

            int[,] result = rotatingMatrix.execute(input);
            for (int i = 0; i < result.GetLength(0); i++) {
                for (int j = 0; j < result.GetLength(1); j++) {
                    Console.Write(result[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void SortedSquaredArrayM(){
            SortedSquaredArray sortedSquaredArray = new SortedSquaredArray();
            int[] result = sortedSquaredArray.run(new int[] {-9, -7, -5, -2});
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public void InfixExpressionEvaluationM(){
            InfixExpressionEvaluation infixExpressionEvaluation = new InfixExpressionEvaluation();
            Console.WriteLine(infixExpressionEvaluation.evaluate("55 + 3 * 100 "));
        }

        public void WordBreakM(){
            WordBreakC WordBreakC = new WordBreakC();
            WordBreakC.wordBreak("iloveicecreamandmango");
            Console.WriteLine("\n\n");
            WordBreakC.wordBreak("ilovesamsungmobile");
        }

        public void IntersectionPointLinkedListM(){
            LinkedList list = new LinkedList();

            // creating first linked list  
            list.head1 = new LinkedListNode(3);
            list.head1.next = new LinkedListNode(6);
            list.head1.next.next = new LinkedListNode(15);
            list.head1.next.next.next = new LinkedListNode(15);
            list.head1.next.next.next.next = new LinkedListNode(30);

            // creating second linked list  
            list.head2 = new LinkedListNode(10);
            list.head2.next = new LinkedListNode(15);
            list.head2.next.next = new LinkedListNode(30);

            Console.WriteLine("The node of intersection is " + list.getNode());
        }
        public void PaintingFenceM()
        {
            PaintingFenceC PaintingFenceC = new PaintingFenceC();
            int n = 3, k = 2;
            Console.Write(PaintingFenceC.countWays(n, k));
        }
        public void SlidingWindowMaximumM()
        {
            SlidingWindowMaximumC slidingWindowMaximumC = new SlidingWindowMaximumC();
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = 3;
            slidingWindowMaximumC.printKMax(arr, arr.Length, k);
        }

        public void SudocuM()
        {
            SudocuC sudocuC = new SudocuC();
            int[,] board = {
            {3, 0, 6, 5, 0, 8, 4, 0, 0},
            {5, 2, 0, 0, 0, 0, 0, 0, 0},
            {0, 8, 7, 0, 0, 0, 0, 3, 1},
            {0, 0, 3, 0, 1, 0, 0, 8, 0},
            {9, 0, 0, 8, 6, 3, 0, 0, 5},
            {0, 5, 0, 0, 9, 0, 6, 0, 0},
            {1, 3, 0, 0, 0, 0, 2, 5, 0},
            {0, 0, 0, 0, 0, 0, 0, 7, 4},
            {0, 0, 5, 2, 0, 6, 3, 0, 0}
            };
            int N = board.GetLength(0);

            if (sudocuC.solveSudoku(board, N))
            {
                sudocuC.print(board, N); // print solution 
            }
            else
            {
                Console.Write("No solution");
            }
        }

        public void FindItineraryM()
        {
            FindItineraryC findItineraryC = new FindItineraryC();
            Hashtable dataSet = new Hashtable();
            dataSet.Add("Chennai", "Banglore");
            dataSet.Add("Bombay", "Delhi");
            dataSet.Add("Goa", "Chennai");
            dataSet.Add("Delhi", "Goa");

            findItineraryC.FindItinerary(dataSet);
        }
        public void NQueenProblemM()
        {
            NQueenProblemC nQueenProblemC = new NQueenProblemC();
            nQueenProblemC.solveNQ();

        }
        public void MinPlatformsRequiredM()
        {
            int[] arr = { 900, 940, 950, 1100, 1500, 1800 };
            int[] dep = { 910, 1200, 1120, 1130, 1900, 2000 };
            int n = arr.Length;
            MinPlatformsRequiredC minPlatformsRequiredC = new MinPlatformsRequiredC();
            Console.Write("Minimum Number of " + " Platforms Required = " + minPlatformsRequiredC.findPlatform(arr, dep, n));
        }
        public void IslandsInGraphM()
        {
            IslandsInGraphC islandsInGraphC = new IslandsInGraphC();
            int[,] M = new int[,] {{1, 1, 0, 0, 0},
                               {0, 1, 0, 0, 1},
                               {1, 0, 0, 1, 1},
                               {0, 0, 0, 0, 0},
                               {1, 0, 1, 0, 1}};
            Console.Write("Number of islands is: " + islandsInGraphC.countIslands(M));
        }

        public void LongestDistinctSubstringM()
        {
            LongestDistinctSubstringC longestDistinctSubstringC = new LongestDistinctSubstringC();
            String str = "aabacbebebe";
            longestDistinctSubstringC.GetLongestPalindromicSubString(str, 3);
        }

        public void ClimbingStaircaseM()
        {
            ClimbingStaircaseC climbingStaircaseC = new ClimbingStaircaseC();
            int n = 4;
            int[] steps = { 1, 3, 4 };
            Console.WriteLine(climbingStaircaseC.NoOfWaysToClimdAStaircase(0, n, steps));
        }
        public void AutoCompletionUsingTrieM()
        {
            Trie trie = new Trie();

            trie.Add("dog");
            trie.Add("deer");
            trie.Add("deal");

            var results = trie.Search("de");

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }

        }
        public void MaxSumNonAdjacentM()
        {
            int[] arr = new int[] { 5, 5, 10, 100, 10, 5 };
            MaxSumNonAdjacentC maxSumNonAdjacentC = new MaxSumNonAdjacentC();
            Console.Write(maxSumNonAdjacentC.FindMaxSumNonAdjacent(arr, arr.Length));
        }
        public void PossibleDecodingDP()
        {
            char[] digits = { '1', '2', '3', '4' };
            int n = digits.Length;
            PossibleDecodingDPC possibleDecodingDPC = new PossibleDecodingDPC();
            Console.WriteLine("Count is " + possibleDecodingDPC.GetPossibleDecodingDP(digits, n));
        }
        public void SmallestPositiveNumberM()
        {
            int[] arr = { 0, 10, 2, 1, -10, -20 };
            int arr_size = arr.Length;
            SmallestPositiveNumberC smallestPositiveNumberC = new SmallestPositiveNumberC();
            int missing = smallestPositiveNumberC.findMissing(arr, arr_size);
            Console.WriteLine("The smallest positive missing number is " + missing);
        }
        public void SerializeDeSerializeBinaryTreeM()
        {
            // var node = new NodeString("root", new NodeString("left", 
            // new NodeString("left.left")), new NodeString("right"));
            NodeString root = new NodeString("root")
            {
                left = new NodeString("left"),
                right = new NodeString("right")
            };

            root.left.left = new NodeString("left.left") { };

            SerializeDeSerializeBinaryTreeC serializeDeSerializeBinaryTree = new SerializeDeSerializeBinaryTreeC();

            var serialized = serializeDeSerializeBinaryTree.Serialize(root);

            Console.WriteLine(serialized);
            root = serializeDeSerializeBinaryTree.Deserialize(serialized);

            Console.WriteLine(root.left.left.Value);
        }

        public void BSTFromPreorderTraversalM()
        {
            int[] preOrderTraversal = { 10, 5, 1, 7, 40, 50 };
            BSTFromPreorderTraversalC bstFromPreorderTraversal = new BSTFromPreorderTraversalC();
            NodeInt root = bstFromPreorderTraversal.ConstructBSTFromPreorderTraversal(preOrderTraversal, preOrderTraversal.Length);

            TreeTraversals treeTraversals = new TreeTraversals();
            treeTraversals.PreOrderTreeTraversal(root);

        }
        public void ProductArrayM()
        {
            ProductArray productArray = new ProductArray();
            int[] values = { 10, 3, 5, 6, 2 };    // Product array: 180 600 360 300 900 
            productArray.GenerateProductArray(values, values.Length);
        }
        public void PairOfNumbersEqualsSumM()
        {
            PairOfNumbersEqualsSumC pairOfNumbersEqualsSumC = new PairOfNumbersEqualsSumC();
            int[] values = { 10, 5, 60, 80, 45 };
            pairOfNumbersEqualsSumC.FindPairOfNumbersEqualsSum(values, 70);
        }
        public void DiameterOfBinaryTreeM()
        {
            NodeChar root = new NodeChar('A')
            {
                left = new NodeChar('B'),
                right = new NodeChar('C')
            };

            root.left.left = new NodeChar('D')
            {
                left = new NodeChar('F'),
                right = new NodeChar('G')
            };

            root.left.right = new NodeChar('E')
            {
                //left = new NodeChar('H'),
                //right = new NodeChar('I')
            };
            DiameterOfBinaryTreeC diameterOfBinaryTreeC = new DiameterOfBinaryTreeC();
            Console.WriteLine(diameterOfBinaryTreeC.FindDiameterOfBinaryTree(root));
        }
        public void LowestCommonAncestorBinaryTreeM()
        {
            NodeChar root = new NodeChar('A')
            {
                left = new NodeChar('B'),
                right = new NodeChar('C')
            };

            root.left.left = new NodeChar('D')
            {
                left = new NodeChar('F'),
                right = new NodeChar('G')
            };

            root.left.right = new NodeChar('E')
            {
                //left = new NodeChar('H'),
                //right = new NodeChar('I')
            };
            LowestCommonAncestorBinaryTreeC lowestCommonAncestorBinaryTreeC = new LowestCommonAncestorBinaryTreeC();
            Console.WriteLine(lowestCommonAncestorBinaryTreeC.FindLowestCommonAncestorBinaryTree(root, 'F', 'E'));
        }
        public void SpiralPrintingOfBinaryTreeM()
        {
            NodeChar root = new NodeChar('A')
            {
                left = new NodeChar('B'),
                right = new NodeChar('C')
            };

            root.left.left = new NodeChar('D')
            {
                left = new NodeChar('F'),
                right = new NodeChar('G')
            };

            root.left.right = new NodeChar('E')
            {
                //left = new NodeChar('H'),
                //right = new NodeChar('I')
            };
            SpiralPrintingOfBinaryTreeC spiralPrintingOfBinaryTreeC = new SpiralPrintingOfBinaryTreeC();
            spiralPrintingOfBinaryTreeC.SpiralPrintingOfABinaryTree(root);
        }
        public void SubSetSumEqualsNumArrayM()
        {
            int[] values = { 5, 100, 55, 72, 36, 40, 25 };
            int num = 187;
            SubSetSumArrayC subSetArrayC = new SubSetSumArrayC();
            bool result = subSetArrayC.SubSetSumEqualsSumArrayM(values, values.Length - 1, num);
            Console.WriteLine(result);
            bool dpResult = subSetArrayC.isSubsetSum(values, values.Length - 1, num);
            Console.WriteLine(dpResult);
        }
        public void DuplicateInArrayM()
        {
            DuplicateInArrayC duplicateInArrayC = new DuplicateInArrayC();
            int[] values = { 1, 2, 1, 3 };
            duplicateInArrayC.FindDuplicateInArray(values);
        }
        public void AllPossibleCombinationsOfElementsM()
        {
            AllPossibleCombinationsOfElementsC allPossibleCombinationsOfElementsC = new AllPossibleCombinationsOfElementsC();
            int[] arr = { 1, 2, 3, 4, 5 };
            int k = 5;
            int n = arr.Length;
            int[] data = new int[k];
            allPossibleCombinationsOfElementsC.GetAllPossibleCombinationsOfElements(arr, data, 0, n - 1, 0, k);
        }

        public void LongestPalindromicSubStringM()
        {
            String str = "gdabad";
            LongestPalindromicSubStringC longestPalindromicSubStringC = new LongestPalindromicSubStringC();
            int length = longestPalindromicSubStringC.GetLongestPalindromicSubString(str);
        }
        public void LengthOfLongestPalindromicSubStringM()
        {
            LengthOfLongestPalindromicSubSequenceC longestPalindromicSubStringC = new LengthOfLongestPalindromicSubSequenceC();
            string inputString = "amadamkr";
            int subStringLength = longestPalindromicSubStringC.GetLengthOfLongestPalindromicSubSequenceM(inputString, 0, inputString.Length - 1);
            Console.WriteLine(String.Format("The longest palamdromic substring in {0} is {1}", inputString, subStringLength));

            int otherSubStringLength = longestPalindromicSubStringC.lps(inputString);
            Console.WriteLine(String.Format("The longest palamdromic substring in {0} is {1}", inputString, otherSubStringLength));
        }
        public void SubArrayWithSumGreaterThanNumberM()
        {
            SubArrayWithSumGreaterThanNumberC subArrayWithSumGreaterThanNumberC = new SubArrayWithSumGreaterThanNumberC();
            int[] arr = { 1, 4, 45, 6, 0, 19 };
            int result = subArrayWithSumGreaterThanNumberC.SubArrayWithSumGreaterThanNumber(arr, 51);
            Console.WriteLine("Length is {0}", result);
        }
        public void SubstringOccurranceInStringM()
        {
            SubStringOccurranceInStringC subStringOccurranceInStringC = new SubStringOccurranceInStringC();
            string completeString = "GeeksforGeeks";
            string subString = "Gks";
            int count = subStringOccurranceInStringC.SubStringOccurranceInString1(completeString,
                        subString, completeString.Length, subString.Length);
            Console.WriteLine("Count is : {0}", count);
        }
        public void MaxSumPathFromRootM()
        {
            NodeInt root = new NodeInt(10)
            {
                left = new NodeInt(20),
                right = new NodeInt(30)
            };

            root.left.left = new NodeInt(10)
            {
                left = new NodeInt(50),
                right = new NodeInt(100)
            };

            root.left.right = new NodeInt(200)
            {
                left = new NodeInt(40),
                right = new NodeInt(20)
            };
            MaxPathFromRoot maxPathFromRoot = new MaxPathFromRoot();
            maxPathFromRoot.FindMaxPathFromRoot(root);
        }
        public void RootToLeafSumM()
        {
            NodeInt root = new NodeInt(10)
            {
                left = new NodeInt(20),
                right = new NodeInt(30)
            };

            root.left.left = new NodeInt(100)
            {
                left = new NodeInt(50),
                right = new NodeInt(100)
            };

            root.left.right = new NodeInt(200)
            {
                left = new NodeInt(40),
                right = new NodeInt(20)
            };
            RootToLeafSum rootToLeafSum = new RootToLeafSum();
            Console.WriteLine(rootToLeafSum.FindRootToLeafSum(root, 270));
        }
        public void CalculateMaxProfit()
        {
            StockPrize stockPrize = new StockPrize();

            int[] shareValue = { 100, 20, 50, 40, 60 };
            stockPrize.CalculateMaxProfit(shareValue, shareValue.Length - 1);
        }

        public void CalculateMaxDifference()
        {
            MaxDifference maxDiffrenece = new MaxDifference();
            int[] values = { 100, 20, 50, 40, 90, 5 };
            int result = maxDiffrenece.CalculateMaxDifference(values);
            Console.WriteLine("The max difference within the given set of values is {0} , such that larger value comes after the smallest", result);
        }

        public void CalculateMinDiceThrowsSnakeAndLadders()
        {

            // Let us construct the board given in above diagram
            int n = 30;
            int[] moves = new int[n];
            for (int i = 0; i < n; i++)
                moves[i] = -1;

            // Ladders
            moves[1] = 28;
            moves[2] = 21;
            moves[4] = 7;
            moves[10] = 25;
            moves[19] = 28;

            // Snakes
            moves[26] = 0;
            moves[20] = 8;
            moves[16] = 3;
            moves[18] = 6;

            SnakeAndLadder snakeAndLadder = new SnakeAndLadder();

            Console.WriteLine(snakeAndLadder.GetMinDiceThrows(moves, n));
        }




        public void FibonacciM()
        {
            Fibonacci fibo = new Fibonacci();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} th value in fibonacci series is --> {1}", i, fibo.NthFibonacciValue(i));
            }
        }

        public void BinarySearchM()
        {
            BinarySearch bs = new BinarySearch();
            int[] content = { 2, 4, 80, 90, 150 };
            int value = 90;
            int result = bs.BinarySearchTheValue(content, value, 0, content.Length - 1);
            if (result == -1)
                Console.WriteLine("Element is not present in the list of given values");
            else
                Console.WriteLine("Element is present at index {0}", result);
        }

        public void PerfectSquareM()
        {
            PerfectSquare ps = new PerfectSquare();
            int n = 144;
            int result = ps.CheckPerfectSquare(n, 1, n);
            if (result == -1)
                Console.WriteLine("The given number is not a perfect square");
            else
                Console.WriteLine("The given number is a perfrct square and the squareroot is {0}", result);
        }

        public void TreeTraversalsM()
        {
            TreeTraversals treeTraversals = new TreeTraversals();

            NodeChar root = new NodeChar('A')
            {
                left = new NodeChar('B'),
                right = new NodeChar('C')
            };

            root.left.left = new NodeChar('D')
            {
                //left = new Node('F'),
                //right = new Node('G')
            };

            root.left.right = new NodeChar('E')
            {
                //left = new Node('H'),
                //right = new Node('I')
            };

            treeTraversals.PreOrderTreeTraversal(root);
            Console.WriteLine();

            treeTraversals.InOrderTreeTraversal(root);
            Console.WriteLine();

            treeTraversals.PostOrderTreeTraversal(root);
            Console.WriteLine();
        }

        public void ConstructTreeFromTraversalsM()
        {
            char[] preOrderTraversal = { 'A', 'B', 'D', 'C' };
            char[] inOrderTraversal = { 'D', 'B', 'A', 'C' };
            //char[] postOrderTraversal = { 'D', 'E', 'B', 'C', 'A' };

            ConstructTreeFromTraversal constructTreeFromTraversal = new ConstructTreeFromTraversal();
            NodeChar root = constructTreeFromTraversal.BuildTree(inOrderTraversal, preOrderTraversal, 0, inOrderTraversal.Length - 1);
            TreeTraversals treeTraversals = new TreeTraversals();
            treeTraversals.PostOrderTreeTraversal(root);
        }

        public void TowerOfHanoiM()
        {
            TowerOfHanoi towerOfHanoi = new TowerOfHanoi();
            towerOfHanoi.SolveTowerOfHanoi(3, "A", "B", "C");
        }

    }
}

