using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            LINQtestDB db = new LINQtestDB();

            // db.workers.Add(new Worker() { id = 2, idBoss = 1, idSalary = 1, idType = 1, name = "Петя"});

            var req = db.workers.Join(
                db.bosses,
                e => e.idBoss,
                q => q.id,
                (worker, boss) =>
                new
                {
                    worker.id,
                    worker.name,
                    bossName = boss.name,
                    worker.idSalary,
                    worker.idType
                }).Join(
                        db.salary,
                        e => e.idSalary,
                        q => q.id,
                        (first, salary) =>
                        new
                        {
                            first.id,
                            first.name,
                            first.bossName,
                            salary.salary,
                            first.idType
                        }).Join(
                                db.types,
                                e => e.idType,
                                q => q.id,
                                (second, type) =>
                                new
                                {
                                    second.id,
                                    second.name,
                                    second.bossName,
                                    second.salary,
                                    type.type
                                });

            Console.WriteLine(req);

            foreach (var e in req)
            {
                Console.WriteLine($"{e.id, 4} | {e.name, 10} | {e.bossName, 10} | {e.salary, 10} | {e.type, 10}");
            }


            Console.ReadKey();
        }
    }
}
