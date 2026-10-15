using System;
using System.Collections.Generic;
using System.Linq;

namespace TransportSystemsArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // --- ЗАВДАННЯ 1 ---
            Console.WriteLine("=== Завдання 1: Максимальна кількість повторень 1-ці ===");
            {
                int[] nums = { 1, 1, 0, 1, 1, 1 };
                Console.WriteLine($"Приклад 1: nums = [{string.Join(", ", nums)}] -> Output: {FindMaxConsecutiveOnes(nums)}");
            }
            {
                int[] nums = { 1, 0, 1, 1, 0, 1 };
                Console.WriteLine($"Приклад 2: nums = [{string.Join(", ", nums)}] -> Output: {FindMaxConsecutiveOnes(nums)}\n");
            }

            // --- ЗАВДАННЯ 2 ---
            Console.WriteLine("=== Завдання 2: Числа з парною кількістю цифр ===");
            {
                int[] nums = { 12, 345, 2, 6, 7896 };
                Console.WriteLine($"Приклад 1: nums = [{string.Join(", ", nums)}] -> Output: {FindNumbers(nums)}");
            }
            {
                int[] nums = { 555, 901, 482, 1771 };
                Console.WriteLine($"Приклад 2: nums = [{string.Join(", ", nums)}] -> Output: {FindNumbers(nums)}\n");
            }

            // --- ЗАВДАННЯ 3 ---
            Console.WriteLine("=== Завдання 3: Квадрати відсортованого масиву ===");
            {
                int[] nums = { -4, -1, 0, 3, 10 };
                int[] result = SortedSquares(nums);
                Console.WriteLine($"Приклад 1: nums = [{string.Join(", ", nums)}] -> Output: [{string.Join(", ", result)}]");
            }
            {
                int[] nums = { -7, -3, 2, 3, 11 };
                int[] result = SortedSquares(nums);
                Console.WriteLine($"Приклад 2: nums = [{string.Join(", ", nums)}] -> Output: [{string.Join(", ", result)}]\n");
            }

            // --- ЗАВДАННЯ 4 ---
            Console.WriteLine("=== Завдання 4: Подвійні нулі ===");
            {
                int[] arr = { 1, 0, 2, 3, 0, 4, 5, 0 };
                Console.Write($"Приклад 1: arr = [{string.Join(", ", arr)}] -> ");
                DuplicateZeros(arr);
                Console.WriteLine($"Output: [{string.Join(", ", arr)}]");
            }
            {
                int[] arr = { 1, 2, 3 };
                Console.Write($"Приклад 2: arr = [{string.Join(", ", arr)}] -> ");
                DuplicateZeros(arr);
                Console.WriteLine($"Output: [{string.Join(", ", arr)}]\n");
            }

            Console.WriteLine("=== Завдання 5: Об'єднати відсортований масив ===");
            {
                int[] nums1 = { 1, 2, 3, 0, 0, 0 };
                int m = 3;
                int[] nums2 = { 2, 5, 6 };
                int n = 3;
                Console.Write($"Приклад 1: nums1 = [{string.Join(", ", nums1)}], m = {m}, nums2 = [{string.Join(", ", nums2)}], n = {n} -> ");
                Merge(nums1, m, nums2, n);
                Console.WriteLine($"Output: [{string.Join(", ", nums1)}]");
            }
            {
                int[] nums1 = { 1 };
                int m = 1;
                int[] nums2 = Array.Empty<int>();
                int n = 0;
                Console.Write($"Приклад 2: nums1 = [{string.Join(", ", nums1)}], m = {m}, nums2 = [{string.Join(", ", nums2)}], n = {n} -> ");
                Merge(nums1, m, nums2, n);
                Console.WriteLine($"Output: [{string.Join(", ", nums1)}]");
            }
            {
                int[] nums1 = { 0 };
                int m = 0;
                int[] nums2 = { 1 };
                int n = 1;
                Console.Write($"Приклад 3: nums1 = [{string.Join(", ", nums1)}], m = {m}, nums2 = [{string.Join(", ", nums2)}], n = {n} -> ");
                Merge(nums1, m, nums2, n);
                Console.WriteLine($"Output: [{string.Join(", ", nums1)}]\n");
            }

            // --- ЗАВДАННЯ 6 ---
            Console.WriteLine("=== Завдання 6: Видалити дублікати з відсортованого масиву ===");
            {
                int[] nums = { 1, 1, 2 };
                Console.Write($"Приклад 1: nums = [{string.Join(", ", nums)}] -> ");
                int k = RemoveDuplicates(nums);
                string formattedNums = string.Join(", ", nums.Take(k).Select(x => x.ToString()).Concat(Enumerable.Repeat("_", nums.Length - k)));
                Console.WriteLine($"Output: {k}, nums = [{formattedNums}]");
            }
            {
                int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
                Console.Write($"Приклад 2: nums = [{string.Join(", ", nums)}] -> ");
                int k = RemoveDuplicates(nums);
                string formattedNums = string.Join(", ", nums.Take(k).Select(x => x.ToString()).Concat(Enumerable.Repeat("_", nums.Length - k)));
                Console.WriteLine($"Output: {k}, nums = [{formattedNums}]\n");
            }

            // --- ЗАВДАННЯ 7 ---
            Console.WriteLine("=== Завдання 7: Перевірте, чи існують N і його подвійник ===");
            {
                int[] arr = { 10, 2, 5, 3 };
                Console.WriteLine($"Приклад 1: arr = [{string.Join(", ", arr)}] -> Output: {CheckIfExist(arr).ToString().ToLower()}");
            }
            {
                int[] arr = { 3, 1, 7, 11 };
                Console.WriteLine($"Приклад 2: arr = [{string.Join(", ", arr)}] -> Output: {CheckIfExist(arr).ToString().ToLower()}\n");
            }

            // --- ЗАВДАННЯ 8 ---
            Console.WriteLine("=== Завдання 8: Дійсний гірський масив ===");
            {
                int[] arr = { 2, 1 };
                Console.WriteLine($"Приклад 1: arr = [{string.Join(", ", arr)}] -> Output: {ValidMountainArray(arr).ToString().ToLower()}");
            }
            {
                int[] arr = { 3, 5, 5 };
                Console.WriteLine($"Приклад 2: arr = [{string.Join(", ", arr)}] -> Output: {ValidMountainArray(arr).ToString().ToLower()}");
            }
            {
                int[] arr = { 0, 3, 2, 1 };
                Console.WriteLine($"Приклад 3: arr = [{string.Join(", ", arr)}] -> Output: {ValidMountainArray(arr).ToString().ToLower()}\n");
            }

            // --- ЗАВДАННЯ 9 ---
            Console.WriteLine("=== Завдання 9: Замініть елементи на найбільший елемент справа ===");
            {
                int[] arr = { 17, 18, 5, 4, 6, 1 };
                Console.Write($"Приклад 1: arr = [{string.Join(", ", arr)}] -> ");
                int[] result = ReplaceElements(arr);
                Console.WriteLine($"Output: [{string.Join(", ", result)}]");
            }
            {
                int[] arr = { 400 };
                Console.Write($"Приклад 2: arr = [{string.Join(", ", arr)}] -> ");
                int[] result = ReplaceElements(arr);
                Console.WriteLine($"Output: [{string.Join(", ", result)}]\n");
            }

            // --- ЗАВДАННЯ 10 ---
            Console.WriteLine("=== Завдання 10: Відсортувати масив за парністю ===");
            {
                int[] nums = { 3, 1, 2, 4 };
                int[] result = SortArrayByParity(nums);
                Console.WriteLine($"Приклад 1: nums = [{string.Join(", ", nums)}] -> Output: [{string.Join(", ", result)}]");
            }
            {
                int[] nums = { 0 };
                int[] result = SortArrayByParity(nums);
                Console.WriteLine($"Приклад 2: nums = [{string.Join(", ", nums)}] -> Output: [{string.Join(", ", result)}]");
            }
        }

        // ---------------------------------------------------------
        // 1. Максимальна кількість повторень 1-ці
        // Обмеження: 1 <= nums.Length <= 100 000; nums[i] можуть бути 0 чи 1
        // ---------------------------------------------------------
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            if (nums == null || nums.Length < 1 || nums.Length > 100_000)
                throw new ArgumentException("Довжина nums має бути в межах [1, 100 000].");

            int maxCount = 0;
            int currentCount = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0 && nums[i] != 1)
                    throw new ArgumentException($"Елемент nums[{i}] = {nums[i]} порушує обмеження: дозволені лише 0 або 1.");

                if (nums[i] == 1)
                {
                    currentCount++;
                    if (currentCount > maxCount)
                        maxCount = currentCount;
                }
                else
                {
                    currentCount = 0;
                }
            }
            return maxCount;
        }

        // ---------------------------------------------------------
        // 2. Знайдіть числа з парною кількістю цифр
        // Обмеження: 1 <= nums.Length <= 500; 1 <= nums[i] <= 100 000
        // ---------------------------------------------------------
        public static int FindNumbers(int[] nums)
        {
            if (nums == null || nums.Length < 1 || nums.Length > 500)
                throw new ArgumentException("Довжина nums має бути в межах [1, 500].");

            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 1 || nums[i] > 100_000)
                    throw new ArgumentException($"Елемент nums[{i}] = {nums[i]} має бути в межах [1, 100 000].");

                if (nums[i].ToString().Length % 2 == 0)
                    count++;
            }
            return count;
        }

        // ---------------------------------------------------------
        // 3. Квадрати відсортованого масиву
        // Обмеження: 1 <= nums.Length <= 10 000; -10 000 <= nums[i] <= 10 000; nums відсортований за неспаданням
        // ---------------------------------------------------------
        public static int[] SortedSquares(int[] nums)
        {
            if (nums == null || nums.Length < 1 || nums.Length > 10_000)
                throw new ArgumentException("Довжина nums має бути в межах [1, 10 000].");

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < -10_000 || nums[i] > 10_000)
                    throw new ArgumentException($"Елемент nums[{i}] = {nums[i]} має бути в межах [-10 000, 10 000].");

                if (i > 0 && nums[i] < nums[i - 1])
                    throw new ArgumentException("Масив nums повинен бути відсортований за неспаданням.");
            }

            return nums.Select(x => x * x).OrderBy(x => x).ToArray();
        }

        // ---------------------------------------------------------
        // 4. Подвійні нулі
        // Обмеження: 1 <= arr.Length <= 10 000; 0 <= arr[i] <= 9
        // ---------------------------------------------------------
        public static void DuplicateZeros(int[] arr)
        {
            if (arr == null || arr.Length < 1 || arr.Length > 10_000)
                throw new ArgumentException("Довжина arr має бути в межах [1, 10 000].");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0 || arr[i] > 9)
                    throw new ArgumentException($"Елемент arr[{i}] = {arr[i]} має бути в межах [0, 9].");
            }

            int n = arr.Length;
            int[] copy = (int[])arr.Clone();
            int writeIndex = 0;

            for (int readIndex = 0; readIndex < n && writeIndex < n; readIndex++)
            {
                arr[writeIndex++] = copy[readIndex];
                if (copy[readIndex] == 0 && writeIndex < n)
                {
                    arr[writeIndex++] = 0;
                }
            }
        }

        // ---------------------------------------------------------
        // 5. Об'єднати відсортований масив
        // Обмеження: nums1.Length == m + n; nums2.Length == n; 0 <= m, n <= 200; 1 <= m + n <= 200; -10 <= nums1[i], nums2[j] <= 10
        // ---------------------------------------------------------
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (nums1 == null || nums2 == null)
                throw new ArgumentNullException("Масиви не можуть бути null.");
            if (m < 0 || m > 200 || n < 0 || n > 200 || (m + n) < 1 || (m + n) > 200)
                throw new ArgumentException("Значення m та n мають бути в межах [0, 200], а m + n в межах [1, 200].");
            if (nums1.Length != m + n || nums2.Length != n)
                throw new ArgumentException("Розміри масивів не відповідають умовам: nums1.Length == m + n та nums2.Length == n.");

            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums1[i] < -10 || nums1[i] > 10)
                    throw new ArgumentException($"Елемент nums1[{i}] має бути в межах [-10, 10].");
            }
            for (int j = 0; j < nums2.Length; j++)
            {
                if (nums2[j] < -10 || nums2[j] > 10)
                    throw new ArgumentException($"Елемент nums2[{j}] має бути в межах [-10, 10].");
            }

            Array.Copy(nums2, 0, nums1, m, n);
            Array.Sort(nums1);
        }

        // ---------------------------------------------------------
        // 6. Видалити дублікати з відсортованого масиву
        // Обмеження: 1 <= nums.Length <= 30 000; -100 <= nums[i] <= 100; nums відсортовані за неспаданням
        // ---------------------------------------------------------
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length < 1 || nums.Length > 30_000)
                throw new ArgumentException("Довжина nums має бути в межах [1, 30 000].");

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < -100 || nums[i] > 100)
                    throw new ArgumentException($"Елемент nums[{i}] = {nums[i]} має бути в межах [-100, 100].");
                if (i > 0 && nums[i] < nums[i - 1])
                    throw new ArgumentException("Масив nums повинен бути відсортований у порядку неспадання.");
            }

            int k = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[k - 1])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }

        // ---------------------------------------------------------
        // 7. Перевірте, чи існують N і його подвійник
        // Обмеження: 2 <= arr.Length <= 500; -1 000 <= arr[i] <= 1 000
        // ---------------------------------------------------------
        public static bool CheckIfExist(int[] arr)
        {
            if (arr == null || arr.Length < 2 || arr.Length > 500)
                throw new ArgumentException("Довжина arr має бути в межах [2, 500].");

            HashSet<int> seen = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < -1000 || arr[i] > 1000)
                    throw new ArgumentException($"Елемент arr[{i}] = {arr[i]} має бути в межах [-1000, 1000].");

                if (seen.Contains(arr[i] * 2) || (arr[i] % 2 == 0 && seen.Contains(arr[i] / 2)))
                    return true;

                seen.Add(arr[i]);
            }
            return false;
        }

        // ---------------------------------------------------------
        // 8. Дійсний гірський масив
        // Обмеження: 1 <= arr.Length <= 10 000; 0 <= arr[i] <= 10 000
        // ---------------------------------------------------------
        public static bool ValidMountainArray(int[] arr)
        {
            if (arr == null || arr.Length < 1 || arr.Length > 10_000)
                throw new ArgumentException("Довжина arr має бути в межах [1, 10 000].");

            for (int idx = 0; idx < arr.Length; idx++)
            {
                if (arr[idx] < 0 || arr[idx] > 10_000)
                    throw new ArgumentException($"Елемент arr[{idx}] = {arr[idx]} має бути в межах [0, 10 000].");
            }

            int n = arr.Length;
            if (n < 3) return false;

            int i = 0;
            while (i + 1 < n && arr[i] < arr[i + 1])
                i++;

            if (i == 0 || i == n - 1)
                return false;

            while (i + 1 < n && arr[i] > arr[i + 1])
                i++;

            return i == n - 1;
        }

        // ---------------------------------------------------------
        // 9. Замініть елементи на найбільший елемент з правого боку
        // Обмеження: 1 <= arr.Length <= 10 000; 1 <= arr[i] <= 100 000
        // ---------------------------------------------------------
        public static int[] ReplaceElements(int[] arr)
        {
            if (arr == null || arr.Length < 1 || arr.Length > 10_000)
                throw new ArgumentException("Довжина arr має бути в межах [1, 10 000].");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 1 || arr[i] > 100_000)
                    throw new ArgumentException($"Елемент arr[{i}] = {arr[i]} має бути в межах [1, 100 000].");
            }

            int maxRight = -1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int current = arr[i];
                arr[i] = maxRight;
                if (current > maxRight)
                    maxRight = current;
            }
            return arr;
        }

        // ---------------------------------------------------------
        // 10. Відсортувати масив за парністю
        // Обмеження: 1 <= nums.Length <= 5000; 0 <= nums[i] <= 5000
        // ---------------------------------------------------------
        public static int[] SortArrayByParity(int[] nums)
        {
            if (nums == null || nums.Length < 1 || nums.Length > 5000)
                throw new ArgumentException("Довжина nums має бути в межах [1, 5000].");

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0 || nums[i] > 5000)
                    throw new ArgumentException($"Елемент nums[{i}] = {nums[i]} має бути в межах [0, 5000].");
            }

            return nums.OrderBy(x => x % 2).ToArray();
        }
    }
}