using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Books.API.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Category", "FullDescription", "ISBN", "ReleaseDate", "SmallDescription", "Title" },
                values: new object[,]
                {
                    { 1, "Paulo Coelho", "Fiction, Fantasy", "The Alchemist is a novel by Brazilian author Paulo Coelho that was first published in 1988. It tells the story of Santiago, a shepherd boy who dreams of discovering a treasure hidden in the Egyptian pyramids. Along the way, he meets a series of characters who help him on his journey of self-discovery and personal growth.", "0061122416", "1988", "A fable about following your dreams.", "The Alchemist" },
                    { 2, "George Orwell", "Fiction, Dystopia", "The Alchemist is a novel by Brazilian author Paulo Coelho that was first published in 1988. It tells the story of Santiago, a shepherd boy who dreams of discovering a treasure hidden in the Egyptian pyramids. Along the way, he meets a series of characters who help him on his journey of self-discovery and personal growth.", "0451524934", "1949", "Dystopian novel by George Orwell about totalitarianism and repression of individuality.", "1984" },
                    { 3, "Harper Lee", "Fiction, Drama", "To Kill a Mockingbird is a novel set in the 1930s in the fictional town of Maycomb, Alabama, and is loosely based on the author's own experiences growing up in the South. The story focuses on the trial of a black man accused of raping a white woman, as seen through the eyes of the protagonist, a young girl named Scout Finch. The novel explores themes of racial injustice, prejudice, and the loss of innocence, and has become a classic of modern American literature.", "0446310786", "1960", "A semi-autobiographical novel about racism and injustice in the American South.", "To Kill a Mockingbird" },
                    { 4, "Margaret Atwood", "Fiction, Fantasy", "The Handmaid's Tale is a dystopian novel set in the near future, in a totalitarian society known as Gilead. The story is narrated by a woman named Offred, who is a \"handmaid\" assigned to a high-ranking couple to bear them a child. In this society, women have been stripped of their rights and are valued only for their ability to reproduce. The novel explores themes of oppression, gender roles, and the power of language, and has become a classic of feminist literature.", "038549081X", "1985", "Dystopian novel by Margaret Atwood depicting a totalitarian future where women are property of the state.", "The Handmaid's Tale" },
                    { 5, "J.K. Rowling", "Fiction, Fantasy", "Harry Potter and the Sorcerer's Stone is the first book in the Harry Potter series, written by J.K. Rowling. The novel follows the story of a young orphan boy named Harry Potter, who discovers on his eleventh birthday that he is a wizard. He is soon whisked away to Hogwarts School of Witchcraft and Wizardry, where he learns magic and meets new friends. Along with his friends Ron Weasley and Hermione Granger, Harry uncovers a sinister plot involving the dark wizard Voldemort, who murdered his parents and seeks to return to power. The book has become a beloved classic of children's literature and has inspired a successful film franchise.", "059035342X", "1997", "First novel in the popular fantasy series about an orphan boy who discovers he is a wizard.", "Harry Potter and the Sorcerer's Stone" },
                    { 6, "Jane Austen", "Fiction, Romance", "\"Pride and Prejudice\" is a romantic novel by Jane Austen, published in 1813. The story follows Elizabeth Bennet, the second eldest of five sisters in a family living in rural England during the early 19th century. The novel explores the themes of love, marriage, social class, and manners, as Elizabeth navigates the complicated social hierarchy of the time and tries to find her place in the world. When Elizabeth meets the wealthy and proud Mr. Darcy, they clash at first, but gradually come to understand and appreciate each other. Along the way, Elizabeth's sisters find love and happiness, while she herself must confront her own pride and prejudices in order to find true happiness with Mr. Darcy. Austen's novel is widely regarded as a classic of English literature and a masterpiece of romance and social commentary.", "0141439513", "1813", "Jane Austen's classic novel tells the story of Elizabeth Bennet, a strong-willed young woman who navigates the social hierarchy of early 19th-century England, and her complicated relationship with the enigmatic Mr. Darcy.", "Pride and Prejudice" },
                    { 7, "Ray Bradbury", "Fiction, Dystopia", "\"Fahrenheit 451\" by Ray Bradbury is a classic dystopian novel that explores the dangers of censorship and the importance of literature. In this frightening society, books are banned and \"firemen\" burn any that are found. Guy Montag, a fireman, begins to question the oppressive regime and seeks to rebel against it. Along the way, he meets others who share his desire for freedom and knowledge. With its vivid descriptions and thought-provoking themes, \"Fahrenheit 451\" is a haunting tale that will stay with readers long after they have finished the book.", "0345410017", "1953", "A haunting tale of a dystopian society where books are banned and \"firemen\" burn any that are found.", "Fahrenheit 451" },
                    { 8, "J. D. Salinger", "Fiction, Drama", "\"The Catcher in the Rye\" by J.D. Salinger is a novel that explores the struggles of Holden Caulfield, a teenage boy who has been expelled from his prep school. As he wanders around New York City, Holden encounters various people and situations that challenge his worldview and make him question the nature of adulthood, identity, and society. Through his interactions with his family, peers, and strangers, Holden grapples with his own disillusionment and alienation, trying to make sense of a world that he finds phony and corrupt. Written in a unique and distinctive voice, \"The Catcher in the Rye\" is a coming-of-age story that has resonated with readers of all ages and backgrounds since its publication in 1951.", "0316769177", "1951", "Holden Caulfield, a teenage boy, tries to make sense of the world around him while struggling with his own disillusionment and alienation.", "The Catcher in the Rye" },
                    { 9, "George Orwell", "Fiction, Allegory", "\"Animal Farm\" by George Orwell is a political allegory that tells the story of a group of farm animals who overthrow their human owner and establish a society based on equality and mutual cooperation. At first, everything goes well, with the animals working together to build a new society free from human oppression. However, as time goes by, the pigs, who are the smartest of the animals, begin to take control and form a new ruling class. They use their intelligence to manipulate and exploit the other animals, and gradually become more and more corrupt. In the end, the society that the animals had hoped to create is replaced by a brutal dictatorship, with the pigs in charge and the other animals reduced to mere slaves. \"Animal Farm\" is a powerful critique of the Soviet Union and a warning against the dangers of political corruption and totalitarianism.", "0451526341", "1945", "In this political satire, animals overthrow their human owner and attempt to create an equal society, but soon find themselves ruled by a group of pigs who abuse their power.", "Animal Farm" },
                    { 10, "F. Scott Fitzgerald", "Fiction, Drama", "Set in the decadent era of the 1920s, The Great Gatsby is a cautionary tale of the corrupting influence of wealth and power. Narrated by Nick Carraway, a young man who moves to New York to pursue his fortune, the novel follows the tragic story of Jay Gatsby, a self-made millionaire who is hopelessly in love with Daisy Buchanan, a wealthy and married socialite. As Gatsby attempts to win back Daisy's affection and navigate the treacherous waters of high society, the novel exposes the greed, corruption, and moral decay that lie beneath the glittering surface of the American Dream. With its vivid characters, poetic prose, and powerful themes, The Great Gatsby has become a staple of modern literature and an enduring commentary on the human condition.", "0743273567", "1925", " A tale of love, deception, and tragedy set in the roaring twenties, The Great Gatsby is a timeless classic that explores the dark underbelly of the American Dream.", "The Great Gatsby" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
