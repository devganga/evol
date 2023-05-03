using evol.Application.TodoLists.Queries.ExportTodos;

namespace evol.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
