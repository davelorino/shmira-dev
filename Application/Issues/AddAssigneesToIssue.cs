using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Application.Core;

namespace Application.Issues
{
    public class AddAssigneesToIssue
    {
        public class Command : IRequest<Result<Unit>>
        {
        public List<FrontendIssueAssignees> issue_assignees { get; set; }

        }

        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;
        
            public Handler(DataContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
                
            }
            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                    
                    
                    foreach(var issue_assignee in request.issue_assignees){
                        Console.WriteLine("Current IssueId =");
                        Console.WriteLine(issue_assignee.IssueId);
                        Console.WriteLine("Current Assignee =");
                        Console.WriteLine(issue_assignee.AssigneeId);

                        var issue = await _context.Issues
                            .Include(a => a.assignees)
                            .FirstOrDefaultAsync(x => x.Id.ToString().ToLower() == issue_assignee.IssueId.ToString().ToLower());

                        Console.WriteLine("Found issue =");
                        Console.WriteLine(issue.Id);
                        
                        var assignee = await _context.Assignees
                            .FirstOrDefaultAsync(x => x.Id.ToString().ToLower() == issue_assignee.AssigneeId.ToString().ToLower());

                        Console.WriteLine("Found assignee =");
                        Console.WriteLine(assignee.Id);
                        
                        var already_assigned = issue.assignees.FirstOrDefault(x => x.AssigneeId.ToString().ToLower() == assignee.Id.ToString().ToLower());

                        if(already_assigned == null){
                             var the_issue_assignee_to_add = new IssueAssignee
                            {
                                Issue = issue,
                                Assignee = assignee
                            };
                            issue.assignees.Add(the_issue_assignee_to_add);
                        }
                    }


                     var result = await _context.SaveChangesAsync() > 0;

                    return result ? Result<Unit>.Success(Unit.Value) : Result<Unit>.Failure("Problem adding assignees to issue.");
                  

            }
        }
    }


}