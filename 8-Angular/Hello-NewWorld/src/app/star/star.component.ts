import { Component, Input, OnChanges, OnInit, Output, EventEmitter } from '@angular/core';
import { faStar } from '@fortawesome/free-solid-svg-icons';


@Component({
  selector: 'app-star',
  templateUrl: './star.component.html',
  styleUrls: ['./star.component.css']
})
export class StarComponent implements OnInit, OnChanges {
  @Input()rating:number = 0;
  faStar = faStar;
  starWidth:number = 0;

  @Output() outputRatingEmitter  = new EventEmitter<number>(); 

  constructor() { }
  ngOnChanges(): void {
    this.starWidth =this.rating*90/5;

  }

  ngOnInit(): void {
    
  }

  onStarClicked():void{
    this.outputRatingEmitter.emit(this.rating);
  }

}
