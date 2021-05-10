using System;

namespace PL.Validation
{
    public class ValidationException : Exception//шаблон обработки исключений
    {
        public ValidationException() : base() { }//конструктор по умолчанию 
        public ValidationException(string message) : base(message) { }//стандартный шаблон 
        public ValidationException(string message, Exception ex) : base(message, ex) { }//вложенные исключения
    }
}
