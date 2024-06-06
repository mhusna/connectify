using ConnectifyHub.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectifyHub.Application.Features.Queries.PostQueries
{
    public class PostGetAll : IRequest<List<PostDTO>>
    {

    }

    public class PostDTO
    {
        public int ID { get; set; }
        public string PostContent { get; set; }
    }

    public class PostGetAllQueryHandler : IRequestHandler<PostGetAll, List<PostDTO>>
    {
        private readonly IPostRepository _postRepository;

        public PostGetAllQueryHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        async Task<List<PostDTO>> IRequestHandler<PostGetAll, List<PostDTO>>.Handle(PostGetAll request, CancellationToken cancellationToken)
        {
            var result = await _postRepository.GetAll();
            return result.Select(p => new PostDTO() { ID = p.ID, PostContent = p.PostContent }).ToList();
        }
    }
}
