# Итоговая задача 
## Задача:
_Напиcать программу, кторая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами._
### Примеры:
* [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
* [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
* [“Russia”, “Denmark”, “Kazan”] → []
----
### Описание алгоритма решения задачи:
* _Объявляем два массива - основной и второй, имеющий длину как у первого._
* _Создаем метод в котором создаем переменную count = 0._
* _Объявляем цикл в котором выполняется проверка условия (<= 3)._ 
* _Если условия из пункта выше выполняется, то элемент первого массива заносится в count и становится элементом второго массива._
* _После присвоения переменная count увеличивается на 1 и так до конца цикла._
* _Сщздается второй метод, позвляющий вывести новый получившийся массив._
