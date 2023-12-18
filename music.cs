using System.Diagnostics; // Импортируем пространство имен System.Diagnostics

HttpClient client = new HttpClient(); // Создаем экземпляр HttpClient
HttpResponseMessage response = await client.GetAsync("https://rur.hitmotop.com/get/music/20220726/SHAMAN_-_YA_RUSSKIJJ_74622610.mp3");
// Отправляем GET запрос на указанный URL и получаем ответ
byte[] data = response.Content.ReadAsByteArrayAsync().Result; // Читаем содержимое ответа в виде массива байтов
File.WriteAllBytes("C:\\Users\\Nitro 5\\Рабочий стол\\Я РУССКИЙ.mp3", data); // Записываем полученные данные в файл по указанному пути

Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\Nitro 5\\Рабочий стол\\Я РУССКИЙ.mp3", UseShellExecute = true });
// Запускаем процесс, чтобы открыть файл с помощью программы по умолчанию
