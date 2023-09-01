export class SingleBlogPost {

  category: string;
  title: string;
  date: string;
  context: string;
  readMore: string;

  constructor(category: string, title: string, date: string, context: string, readMore: string) {
    this.category = category;
    this.title = title;
    this.date = date;
    this.context = context;
    this.readMore = readMore;
  }
}