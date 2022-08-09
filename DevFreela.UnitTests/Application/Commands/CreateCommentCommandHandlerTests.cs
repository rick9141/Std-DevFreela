using DevFreela.Application.Commands.CreateComment;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace DevFreela.UnitTests.Application.Commands
{
    public class CreateCommentCommandHandlerTests
    {
        [Fact]
        public async Task CommentInputDataIsOk_Executed_ReturnProjectId()
        {
            var projectRepositoryMock = new Mock<IProjectRepository>();

            var createCommentCommand = new CreateCommentCommand
            {
                Content = "Comentário no projeto um",
                IdProject = 1,
                IdUser = 2
            };

            var createCommentCommandHandler = new CreateCommentCommandHandler(projectRepositoryMock.Object);

            var comment = await createCommentCommandHandler.Handle(createCommentCommand, new CancellationToken());

           Assert.NotNull(createCommentCommandHandler);
           Assert.NotNull(comment);

            projectRepositoryMock.Verify(pr => pr.AddCommentAsync(It.IsAny<ProjectComment>()), Times.Once);
        }
    }
}
