# Лабораторная работа 33-34: Полноценный CRUD с базой данных

**Студент:** Салалыкина Олеся || Дунюшкин Никита
**Курс:** 3 курс
**Группа:** ИСП-233

---

## Описание проекта

**NotesApp** — это RESTful API для управления заметками и категориями. Приложение позволяет создавать, просматривать, редактировать и удалять заметки, группируя их по категориям.

---

## Структура проекта
NotesApp/
├── Controllers/
│ ├── CategoriesController.cs
│ └── NotesController.cs
├── Data/
│ └── AppDbContext.cs
├── Helpers/
│ └── ApiResponse.cs
├── Models/
│ ├── Category.cs
│ ├── Note.cs
│ └── DTOs/
│ ├── CategoryDtos.cs
│ ├── NoteDtos.cs
│ └── NoteFilterDto.cs
├── Repositories/
│ ├── ICategoryRepository.cs
│ ├── CategoryRepository.cs
│ ├── INoteRepository.cs
│ └── NoteRepository.cs
├── Migrations/
├── Program.cs
├── appsettings.json
└── notesapp.db

 ---

## Таблица маршрутов API

| Метод  | URL                        | Описание                        | Коды ответа   |
|--------|----------------------------|---------------------------------|---------------|
| GET    | /api/categories            | Все категории с кол-вом заметок | 200           |
| GET    | /api/categories/{id}       | Одна категория                  | 200, 404      |
| GET    | /api/categories/{id}/notes | Категория с заметками           | 200, 404      |
| POST   | /api/categories            | Создать категорию               | 201, 400      |
| PUT    | /api/categories/{id}       | Обновить категорию              | 200, 400, 404 |
| DELETE | /api/categories/{id}       | Удалить категорию               | 204, 400, 404 |
| GET    | /api/notes                 | Все заметки с фильтрами         | 200           |
| GET    | /api/notes/{id}            | Одна заметка                    | 200, 404      |
| POST   | /api/notes                 | Создать заметку                 | 201, 400      |
| PUT    | /api/notes/{id}            | Обновить заметку                | 200, 400, 404 |
| PATCH  | /api/notes/{id}/pin        | Закрепить / открепить           | 200, 404      |
| PATCH  | /api/notes/{id}/archive    | Архивировать / восстановить     | 200, 404      |
| DELETE | /api/notes/{id}            | Удалить заметку                 | 204, 404      |

---

## Главные выводы

1. **Паттерн Repository** — не лишняя абстракция, а способ держать код управляемым при росте проекта.

2. **Data Annotations** решают двойную задачу: валидируют входные данные и задают ограничения в БД.

3. **Единый формат ответа (ApiResponse)** упрощает жизнь фронтенду — он всегда знает, что ждать от сервера.

4. **DeleteBehavior.Restrict** защищает данные от случайного каскадного удаления.

5. **Include() и проекция в DTO через Select()** — правильный способ получить связанные данные без N+1 проблемы.