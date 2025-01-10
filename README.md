# TestTaskPlaynera

Для начала я разбил данную задачу на более мелкие. Что у нас имеется:
Предмет который мы можем двигать мышкой
Получить позицию мыши по мировым координатам относительно камеры
Взаимодествие предмета при зажатии мыши и отпускании
Реализация "глубины" положения предмета
Реализация перемещения по комнате через кнопки

1. Мы создадим объект и повесим на него Rigidbody2D и BoxCollider для того что бы у объекта была физика
2. Мы получаем позицию мыши через метод ScreenToWorldPoint и обязательно сохряняем координаты. Высчитываем разницу между положением объекта и мышкой для того, что бы объект не прыграл и вел себя корректно. Сделал не через UI, поэтому работаю без интерфейсов типа: IDragHandler и т.п.
3. Дальше реализовал эффект глубины через отключение скорости и гравитации, что бы в определенной зоне на полу мы могли передвигать объект так, что бы он не падал. Вешаем на пол коллайдер и ставим галочку IsTrigger
4. Обнуляем и ресетим объект в классе InteractableItem через публичные методы Reset и Zeroize.
5. Так же в классе DragAndDrop есть флаг _isDragging который нам нужен для того, что бы понять когда мы обнуляем, а когда ресетим и публичное свойство которое возвращает флаг _isDragging.
6. Для перемещения по кнопкам мы используем интерфейсы IPointerDownHandler, IPointerUpHandler для определения зажатия кнопки
7. Реализацию полок сделал через пустые объект с коллайдером, для того, что бы объект не падал сквозь них.

Из общего могу еще выделить знания в области подписки и отписки. Как правило мы подписываемся и отписываемся в метода OnEnable и OnDisable соответственно.
Обязательно, если у нас есть, к примеру, Rigidbody мы должны вызвать GetComponent в Awake и [RequireComponent(typeof(Rigidbody2D))] это предотврощает ошибки в дальнейшем.
