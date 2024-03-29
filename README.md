# WinFormsAppHistogram
# Задача 3. Хистограма

Дадени са n цели числа в интервала [1…1000]. От тях някакъв процент p1 са под 200, друг процент p2 са от 200 до 399, друг процент p3 са от 400 до 599, друг процент p4 са от 600 до 799 и останалите p5 процента са от 800 нагоре. Да се напише програма, която изчислява и отпечатва процентите p1, p2, p3, p4 и p5.

## Пример

Имаме n = 20 числа: 53, 7, 56, 180, 450, 920, 12, 7, 150, 250, 680, 2, 600, 200, 800, 799, 199, 46, 128, 65. Получаваме следното разпределение и визуализация:

# Задача 3. Хистограма

| Диапазон   | Числа в диапазона                                   | Брой числа | Процент                     |
|------------|-----------------------------------------------------|------------|-----------------------------|
| < 200      | 53, 7, 56, 180, 12, 7, 150, 2, 199, 46, 128, 65     | 12         | p1 = 12 / 20 * 100 = 60.00% |
| 200 … 399  | 250, 200                                            | 2          | p2 = 2 / 20 * 100 = 10.00%  |
| 400 … 599  | 450                                                 | 1          | p3 = 1 / 20 * 100 = 5.00%   |
| 600 … 799  | 680, 600, 799                                       | 3          | p4 = 3 / 20 * 100 = 15.00%  |
| ≥ 800      | 920, 800                                            | 2          | p5 = 2 / 20 * 100 = 10.00%  |


## Вход

На първия ред от входа стои цялото число n (1 ≤ n ≤ 1000) – брой числа. На следващите n реда стои по едно цяло число в интервала [1…1000] – числата върху които да бъде изчислена хистограмата.

## Изход

Да се отпечата на конзолата хистограмата – 5 реда, всеки от които съдържа число между 0% и 100%, с точност две цифри след десетичната точка, например 25.00%, 66.67%, 57.14%.

## Примерен вход и изход

# Вход и Изход

| Вход | Изход        |   | Вход | Изход        |   | Вход | Изход        |   | Вход | Изход        |   | Вход | Изход        |
|------|--------------|---|------|--------------|---|------|--------------|---|------|--------------|---|------|--------------|
| 3    | 66.67%       |   | 4    | 75.00%       |   | 7    | 14.29%       |   | 9    | 33.33%       |   | 14   | 57.14%       |
| 1    | 0.00%        |   | 53   | 0.00%        |   | 800  | 28.57%       |   | 367  | 33.33%       |   | 53   | 14.29%       |
| 2    | 0.00%        |   | 7    | 0.00%        |   | 801  | 14.29%       |   | 99   | 33.33%       |   | 7    | 7.14%        |
| 999  | 0.00%        |   | 56   | 0.00%        |   | 250  | 14.29%       |   | 200  | 11.11%       |   | 56   | 14.29%       |
|      | 33.33%       |   | 999  | 25.00%       |   | 199  | 14.29%       |   | 799  | 11.11%       |   | 180  | 7.14%        |
|      |              |   |      |              |   | 399  | 28.57%       |   | 999  | 11.11%       |   | 450  |              |
|      |              |   |      |              |   | 599  | 14.29%       |   | 333  |              |   | 920  |              |
|      |              |   |      |              |   | 799  | 14.29%       |   | 555  |              |   | 12   |              |
|      |              |   |      |              |   |      |              |   | 111  |              |   | 7    |              |
|      |              |   |      |              |   |      |              |   | 9    |              |   | 150  |              |
|      |              |   |      |              |   |      |              |   |      |              |   | 250  |              |
|      |              |   |      |              |   |      |              |   |      |              |   | 680  |              |
|      |              |   |      |              |   |      |              |   |      |              |   | 2    |              |
|      |              |   |      |              |   |      |              |   |      |              |   | 600  |              |
|      |              |   |      |              |   |      |              |   |      |              |   | 200  |              |
