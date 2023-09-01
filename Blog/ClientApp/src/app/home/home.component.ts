import { Component, OnInit, Inject } from '@angular/core';
import { SingleBlogPost } from '../single-blog/single-blog.model';
import { HttpClient, HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  
  singleblogposts: SingleBlogPost[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<SingleBlogPost[]>("http://localhost:44456/blogpost")
      .subscribe(data => {
        this.singleblogposts = data;
      });

  }

  ngOnInit() {

  }

  //function to return list of numbers from 0 to n-1
  numSequence(n: number): Array<number> {
    return Array(n);
  }

}


