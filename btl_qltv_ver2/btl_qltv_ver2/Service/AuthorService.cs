using btl_qltv_ver2.domain;
using btl_qltv_ver2.sdi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Service
{
    interface AuthorService
    {
        List<Author> getAuthors();
        Author insertAuthor(AuthorInsertSdi authorInsertSdi);
        Author getAuthorById(String AuthorId);

        Author updateAuthor(AuthorUpdateSdi authorUpdateSdi);

        List<Author> searchAuthors(AuthorSearchSdi authorSearchSdi);

        String deleteAuthor(String authorId);

        Boolean isExistAuthor(String authorId);

        List<Author> filterAuthors(String firstName, String midName, String lastName);

        List<String> filterById(String authorId);
    }
}
