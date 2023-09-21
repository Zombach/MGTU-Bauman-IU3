; Задание 1. Сложение чисел, записанных по адресам 0В00h и 0В01h, и запись результата по адресу 0В02h.

$ADR 0000h    ; Адрес начала программы

	; Инициализация ячеек памяти значениями из порта 20 и 25
	IN 20h		; Чтение данных из порта 20h в аккумулятор
	STA 0B00h	; Передача содержимого аккумулятора в ячейку памяти с адресом 0B00h
	IN 25h		; Чтение данных из порта 25h в аккумулятор	
	STA 0B01h	; Передача содержимого аккумулятора в ячейку памяти с адресом 0B01h

	; Сложение
	LDA 0B00h	; Передача содержимого ячейки памяти с адресом 0B00h в аккумулятор
	MOV B,A		; Передача содержимого аккумулятора в регистр B
        LDA 0B01h	; Передача содержимого ячейки памяти с адресом 0B01h в аккумулятор
        ADD B		; Сложение содержимого регистра B с содержимым аккумулятора и сохранение итога в аккумуляторе
        STA 0B02h	; Запись содержимого аккумулятора в ячейку памяти с адресом 0B02h
	; Вывод
        OUT 30h		; Вывод результата из аккумулятора на порт 30h
END:    NOP		; Метка завершения программы
