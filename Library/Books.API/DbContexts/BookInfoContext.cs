﻿using Books.API.Entities;
using Books.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Books.API.DbContexts
{
    public class BookInfoContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BookInfoContext(DbContextOptions<BookInfoContext> options )
            : base(options) 
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    ISBN = "0061122416",
                    Title = "The Alchemist",
                    SmallDescription = "A fable about following your dreams.",
                    FullDescription = "The Alchemist is a novel by Brazilian author Paulo Coelho that was first published in 1988. It tells the story of Santiago, a shepherd boy who dreams of discovering a treasure hidden in the Egyptian pyramids. Along the way, he meets a series of characters who help him on his journey of self-discovery and personal growth.",
                    ReleaseDate = "1988",
                    Author = "Paulo Coelho",
                    Category = "Fiction, Fantasy"
                },
                new Book
                {
                    Id = 2,
                    ISBN = "0451524934",
                    Title = "1984",
                    SmallDescription = "Dystopian novel by George Orwell about totalitarianism and repression of individuality.",
                    FullDescription = "The Alchemist is a novel by Brazilian author Paulo Coelho that was first published in 1988. It tells the story of Santiago, a shepherd boy who dreams of discovering a treasure hidden in the Egyptian pyramids. Along the way, he meets a series of characters who help him on his journey of self-discovery and personal growth.",
                    ReleaseDate = "1949",
                    Author = "George Orwell",
                    Category = "Fiction, Dystopia"
                },
                new Book
                {
                    Id = 3,
                    ISBN = "0446310786",
                    Title = "To Kill a Mockingbird",
                    SmallDescription = "A semi-autobiographical novel about racism and injustice in the American South.",
                    FullDescription = "To Kill a Mockingbird is a novel set in the 1930s in the fictional town of Maycomb, Alabama, and is loosely based on the author's own experiences growing up in the South. The story focuses on the trial of a black man accused of raping a white woman, as seen through the eyes of the protagonist, a young girl named Scout Finch. The novel explores themes of racial injustice, prejudice, and the loss of innocence, and has become a classic of modern American literature.",
                    ReleaseDate = "1960",
                    Author = "Harper Lee",
                    Category = "Fiction, Drama"
                },
                new Book
                {
                    Id = 4,
                    ISBN = "038549081X",
                    Title = "The Handmaid's Tale",
                    SmallDescription = "Dystopian novel by Margaret Atwood depicting a totalitarian future where women are property of the state.",
                    FullDescription = "The Handmaid's Tale is a dystopian novel set in the near future, in a totalitarian society known as Gilead. The story is narrated by a woman named Offred, who is a \"handmaid\" assigned to a high-ranking couple to bear them a child. In this society, women have been stripped of their rights and are valued only for their ability to reproduce. The novel explores themes of oppression, gender roles, and the power of language, and has become a classic of feminist literature.",
                    ReleaseDate = "1985",
                    Author = "Margaret Atwood",
                    Category = "Fiction, Fantasy"
                },
                new Book
                {
                    Id = 5,
                    ISBN = "059035342X",
                    Title = "Harry Potter and the Sorcerer's Stone",
                    SmallDescription = "First novel in the popular fantasy series about an orphan boy who discovers he is a wizard.",
                    FullDescription = "Harry Potter and the Sorcerer's Stone is the first book in the Harry Potter series, written by J.K. Rowling. The novel follows the story of a young orphan boy named Harry Potter, who discovers on his eleventh birthday that he is a wizard. He is soon whisked away to Hogwarts School of Witchcraft and Wizardry, where he learns magic and meets new friends. Along with his friends Ron Weasley and Hermione Granger, Harry uncovers a sinister plot involving the dark wizard Voldemort, who murdered his parents and seeks to return to power. The book has become a beloved classic of children's literature and has inspired a successful film franchise.",
                    ReleaseDate = "1997",
                    Author = "J.K. Rowling",
                    Category = "Fiction, Fantasy"
                },
                new Book
                {
                    Id = 6,
                    ISBN = "0141439513",
                    Title = "Pride and Prejudice",
                    SmallDescription = "Jane Austen's classic novel tells the story of Elizabeth Bennet, a strong-willed young woman who navigates the social hierarchy of early 19th-century England, and her complicated relationship with the enigmatic Mr. Darcy.",
                    FullDescription = "\"Pride and Prejudice\" is a romantic novel by Jane Austen, published in 1813. The story follows Elizabeth Bennet, the second eldest of five sisters in a family living in rural England during the early 19th century. The novel explores the themes of love, marriage, social class, and manners, as Elizabeth navigates the complicated social hierarchy of the time and tries to find her place in the world. When Elizabeth meets the wealthy and proud Mr. Darcy, they clash at first, but gradually come to understand and appreciate each other. Along the way, Elizabeth's sisters find love and happiness, while she herself must confront her own pride and prejudices in order to find true happiness with Mr. Darcy. Austen's novel is widely regarded as a classic of English literature and a masterpiece of romance and social commentary.",
                    ReleaseDate = "1813",
                    Author = "Jane Austen",
                    Category = "Fiction, Romance"
                },
                new Book
                {
                    Id = 7,
                    ISBN = "0345410017",
                    Title = "Fahrenheit 451",
                    SmallDescription = "A haunting tale of a dystopian society where books are banned and \"firemen\" burn any that are found.",
                    FullDescription = "\"Fahrenheit 451\" by Ray Bradbury is a classic dystopian novel that explores the dangers of censorship and the importance of literature. In this frightening society, books are banned and \"firemen\" burn any that are found. Guy Montag, a fireman, begins to question the oppressive regime and seeks to rebel against it. Along the way, he meets others who share his desire for freedom and knowledge. With its vivid descriptions and thought-provoking themes, \"Fahrenheit 451\" is a haunting tale that will stay with readers long after they have finished the book.",
                    ReleaseDate = "1953",
                    Author = "Ray Bradbury",
                    Category = "Fiction, Dystopia"
                },
                new Book
                {
                    Id = 8,
                    ISBN = "0316769177",
                    Title = "The Catcher in the Rye",
                    SmallDescription = "Holden Caulfield, a teenage boy, tries to make sense of the world around him while struggling with his own disillusionment and alienation.",
                    FullDescription = "\"The Catcher in the Rye\" by J.D. Salinger is a novel that explores the struggles of Holden Caulfield, a teenage boy who has been expelled from his prep school. As he wanders around New York City, Holden encounters various people and situations that challenge his worldview and make him question the nature of adulthood, identity, and society. Through his interactions with his family, peers, and strangers, Holden grapples with his own disillusionment and alienation, trying to make sense of a world that he finds phony and corrupt. Written in a unique and distinctive voice, \"The Catcher in the Rye\" is a coming-of-age story that has resonated with readers of all ages and backgrounds since its publication in 1951.",
                    ReleaseDate = "1951",
                    Author = "J. D. Salinger",
                    Category = "Fiction, Drama"
                },
                new Book
                {
                    Id = 9,
                    ISBN = "0451526341",
                    Title = "Animal Farm",
                    SmallDescription = "In this political satire, animals overthrow their human owner and attempt to create an equal society, but soon find themselves ruled by a group of pigs who abuse their power.",
                    FullDescription = "\"Animal Farm\" by George Orwell is a political allegory that tells the story of a group of farm animals who overthrow their human owner and establish a society based on equality and mutual cooperation. At first, everything goes well, with the animals working together to build a new society free from human oppression. However, as time goes by, the pigs, who are the smartest of the animals, begin to take control and form a new ruling class. They use their intelligence to manipulate and exploit the other animals, and gradually become more and more corrupt. In the end, the society that the animals had hoped to create is replaced by a brutal dictatorship, with the pigs in charge and the other animals reduced to mere slaves. \"Animal Farm\" is a powerful critique of the Soviet Union and a warning against the dangers of political corruption and totalitarianism.",
                    ReleaseDate = "1945",
                    Author = "George Orwell",
                    Category = "Fiction, Allegory"
                },
                new Book
                {
                    Id = 10,
                    ISBN = "0743273567",
                    Title = "The Great Gatsby",
                    SmallDescription = " A tale of love, deception, and tragedy set in the roaring twenties, The Great Gatsby is a timeless classic that explores the dark underbelly of the American Dream.",
                    FullDescription = "Set in the decadent era of the 1920s, The Great Gatsby is a cautionary tale of the corrupting influence of wealth and power. Narrated by Nick Carraway, a young man who moves to New York to pursue his fortune, the novel follows the tragic story of Jay Gatsby, a self-made millionaire who is hopelessly in love with Daisy Buchanan, a wealthy and married socialite. As Gatsby attempts to win back Daisy's affection and navigate the treacherous waters of high society, the novel exposes the greed, corruption, and moral decay that lie beneath the glittering surface of the American Dream. With its vivid characters, poetic prose, and powerful themes, The Great Gatsby has become a staple of modern literature and an enduring commentary on the human condition.",
                    ReleaseDate = "1925",
                    Author = "F. Scott Fitzgerald",
                    Category = "Fiction, Drama"
                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
