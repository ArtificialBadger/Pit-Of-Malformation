// See https://aka.ms/new-console-template for more information
using Bilmuri;
using Bilmuri.TournamentEntrants;

Console.WriteLine("Hello, World!");

var entrants = new List<GenericTournamentEntrant>
{
	new GenericTournamentEntrant(Guid.Parse("0e1ea89f-3b9b-4275-8feb-5bb0aa24a318"), "Armando the Stronk", "Big and Stronk", 10),
	new GenericTournamentEntrant(Guid.Parse("47ccb6d9-0869-4329-8c1d-3bb170e027f2"), "Armando the Stronk", "Big and Stronk", 10),
	new GenericTournamentEntrant(Guid.Parse("40283774-2e21-43c9-8b98-f8f0dcc24266"), "Armando the Stronk", "Big and Stronk", 10),
	new GenericTournamentEntrant(Guid.Parse("bb2b3d52-917e-49ff-b922-1df0dedc17b9"), "Armando the Stronk", "Big and Stronk", 10),
	new GenericTournamentEntrant(Guid.Parse("8c7af471-d060-43d8-a539-3b9f1616204f"), "Armando the Stronk", "Big and Stronk", 10),
};

var a = "test";
var b = a;
a = b;


