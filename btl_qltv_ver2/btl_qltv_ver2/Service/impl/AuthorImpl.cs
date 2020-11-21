using btl_qltv_ver2.Bean;
using btl_qltv_ver2.domain;
using btl_qltv_ver2.repos;
using btl_qltv_ver2.sdi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_qltv_ver2.Service.impl
{
    class AuthorImpl : AuthorService
    {
        private AuthorRepoService authorRepoService;

        public AuthorImpl()
        {
            authorRepoService = AuthorRepoServiceBean.getBean();
        }

        public string deleteAuthor(string authorId)
        {
            return authorRepoService.deleteAuthor(authorId);
        }

        public List<Author> filterAuthors(string firstName, string midName, string lastName)
        {
            return authorRepoService.filterAuthors(firstName,midName,lastName);
        }

        public List<string> filterById(string authorId)
        {
            throw new NotImplementedException();
        }

        public Author getAuthorById(string AuthorId)
        {
            return authorRepoService.getAuthorById(AuthorId);
        }

        public List<Author> getAuthors()
        {
            return authorRepoService.getAuthors();
        }

        public Author insertAuthor(AuthorInsertSdi authorInsertSdi)
        {
            return authorRepoService.insertAuthor(authorInsertSdi);
        }

        public bool isExistAuthor(string authorId)
        {
            return authorRepoService.isExistAuthor(authorId);
        }

        public List<Author> searchAuthors(AuthorSearchSdi authorSearchSdi)
        {
            return authorRepoService.searchAuthors(authorSearchSdi);
        }

        public Author updateAuthor(AuthorUpdateSdi authorUpdateSdi)
        {
            return authorRepoService.updateAuthor(authorUpdateSdi);
        }
    }
}
