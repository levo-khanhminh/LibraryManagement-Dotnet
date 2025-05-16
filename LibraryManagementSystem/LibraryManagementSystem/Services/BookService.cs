// using LibraryManagementSystem.Models;
//
// namespace LibraryManagementSystem.Services;
//
// public class BookService
// {
//     private static List<Category> Categories = new List<Category>
//     {
//         new Category("Fiction", "Fictional works including novels and storytelling."),
//         new Category("Biography", "Books about a person's life story."),
//         new Category("Science", "Scientific theories and explorations."),
//         new Category("Classic", "Timeless literary works.")
//     };
//
//     private static List<Book> Books = new List<Book>
//     {
//         new Book(
//             id: 1,
//             title: "Educated",
//             author: "Tara Westover",
//             publisher: "Random House",
//             publishedDate: new DateTime(2018, 2, 20),
//             description:
//             "A memoir by Tara Westover about growing up in a strict and abusive household in rural Idaho but eventually escaping through education.",
//             categoryId: 2,
//             category: Categories[1],
//             imageUrl: "/images/educated-book.jpg"
//         ),
//         new Book(
//             id: 2,
//             title: "Kane and Abel",
//             author: "Jeffrey Archer",
//             publisher: "Hodder & Stoughton",
//             publishedDate: new DateTime(1979, 9, 1),
//             description:
//             "A saga about two ambitious men born on the same day on opposite sides of the world whose paths eventually cross.",
//             categoryId: 1,
//             category: Categories[0],
//             imageUrl: "/images/kaneAndabel-book.jpg"
//         ),
//         new Book(
//             id: 3,
//             title: "Parallel Worlds",
//             author: "Michio Kaku",
//             publisher: "Doubleday",
//             publishedDate: new DateTime(2004, 12, 28),
//             description: "A book about parallel universes, string theory, and the possibility of multiple dimensions.",
//             categoryId: 3,
//             category: Categories[2],
//             imageUrl: "/images/parallelworlds-book.jpg"
//         ),
//         new Book(
//             id: 4,
//             title: "The Book Thief",
//             author: "Markus Zusak",
//             publisher: "Picador",
//             publishedDate: new DateTime(2005, 3, 14),
//             description:
//             "A historical novel set in Nazi Germany narrated by Death, focusing on a young girl's relationship with books.",
//             categoryId: 1,
//             category: Categories[0],
//             imageUrl: "/images/thebookthief-book.jpg"
//         ),
//         new Book(
//             id: 5,
//             title: "The Three Musketeers",
//             author: "Alexandre Dumas",
//             publisher: "Baudry's European Library",
//             publishedDate: new DateTime(1844, 3, 1),
//             description:
//             "A classic adventure novel about the swashbuckling musketeers Athos, Porthos, Aramis, and D'Artagnan.",
//             categoryId: 4,
//             category: Categories[3],
//             imageUrl: "/images/ThreeMustkeeters.jpg"
//         ),
//         new Book(
//             id: 6,
//             title: "Sapiens: A Brief History of Humankind",
//             author: "Yuval Noah Harari",
//             publisher: "Harper",
//             publishedDate: new DateTime(2011, 6, 4),
//             description: "Explores the history and impact of Homo sapiens, from prehistoric times to the modern age.",
//             categoryId: 3,
//             category: Categories[2],
//             imageUrl: "/images/sapiens-book.jpg"
//         ),
//         new Book(
//             id: 7,
//             title: "Pride and Prejudice",
//             author: "Jane Austen",
//             publisher: "T. Egerton, Whitehall",
//             publishedDate: new DateTime(1813, 1, 28),
//             description:
//             "A classic romantic novel that explores manners, upbringing, morality, and marriage in early 19th century England.",
//             categoryId: 4,
//             category: Categories[3],
//             imageUrl: "/images/prideprejudice-book.jpg"
//         ),
//         new Book(
//             id: 8,
//             title: "The Theory of Everything",
//             author: "Stephen Hawking",
//             publisher: "Bantam Books",
//             publishedDate: new DateTime(2002, 4, 30),
//             description:
//             "A book explaining a range of subjects in cosmology, including the Big Bang, black holes, and light cones, in a way accessible to non-scientists.",
//             categoryId: 3,
//             category: Categories[2],
//             imageUrl: "/images/thetheoryofeverything-book.jpg"
//         ),
//         new Book(
//             id: 9,
//             title: "Becoming",
//             author: "Michelle Obama",
//             publisher: "Crown Publishing Group",
//             publishedDate: new DateTime(2018, 11, 13),
//             description: "A deeply personal memoir by the former First Lady of the United States.",
//             categoryId: 2,
//             category: Categories[1],
//             imageUrl: "/images/becoming-book.jpg"
//         ),
//         new Book(
//             id: 10,
//             title: "1984",
//             author: "George Orwell",
//             publisher: "Secker & Warburg",
//             publishedDate: new DateTime(1949, 6, 8),
//             description:
//             "A dystopian social science fiction novel and cautionary tale about the dangers of totalitarianism.",
//             categoryId: 1,
//             category: Categories[0],
//             imageUrl: "/images/1984-book.png"
//         )
//     };
//
//     public List<Book> GetAllBooks()
//     {
//         return Books;
//     }
//
//     public Book GetBookById(int id)
//     {
//         var book = Books.FirstOrDefault(b => b.Id == id);
//         return book;
//     }
// }