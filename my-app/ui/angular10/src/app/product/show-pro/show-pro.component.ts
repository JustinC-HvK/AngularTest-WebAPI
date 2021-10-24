import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-show-pro',
  templateUrl: './show-pro.component.html',
  styleUrls: ['./show-pro.component.css']
})
export class ShowProComponent implements OnInit {

  constructor(private service:SharedService) { }

  ProductList:any=[];
  

  ngOnInit(): void {
    this.refreshProList();
  }
//Refresh will run when app starts^
  refreshProList(){
    this.service.getProList().subscribe(data=>{
      this.ProductList=data
    })
  }

}
