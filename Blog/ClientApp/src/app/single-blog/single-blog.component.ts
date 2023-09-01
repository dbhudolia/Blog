import { Component, OnInit, Input } from '@angular/core';
import { SingleBlogPost } from './single-blog.model';

@Component({
  selector: 'single-blog',
  templateUrl: './single-blog.component.html',
  styleUrls: ['./single-blog.component.css']
})
export class SingleBlogComponent implements OnInit {

  ngOnInit() {
  }

  
  @Input() singleblog: SingleBlogPost;

  constructor() {
    this.singleblog = new SingleBlogPost("Java", "Java Networking", "31 May 2022",
      "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas in pulvinar neque.", "");
  }

}

