import { Component, OnInit } from '@angular/core';
import {NgbModal, ModalDismissReasons, NgbModalOptions} from '@ng-bootstrap/ng-bootstrap';
import { SharedService } from '../shared.service';



@Component({
  selector: 'app-pjesma',
  templateUrl: './pjesma.component.html',
  styleUrls: ['./pjesma.component.css']
})
export class PjesmaComponent implements OnInit {
  PjesmeList:any=[];
  isDtInitialized:boolean = false;
  kategorije:any[]=[];
  constructor(private SharedService:  SharedService,  private modalService:NgbModal) { }

  ngOnInit(): void {
    this.refreshpjList();
  }

  closeResult: string;
  modalOptions:NgbModalOptions;
  kateogorije:any[]=[];
  open(content:any) {

    this.PjesmeList={};

    this.modalService.open(content, this.modalOptions).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });


  }
  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return  `with: ${reason}`;
    }
  }
  refreshpjList(){
    this.SharedService.getPjesmeList().subscribe(data=>{
      this.PjesmeList=data;
     
    });
  }
  
  
 
}
