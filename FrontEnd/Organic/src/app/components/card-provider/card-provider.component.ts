import { Component, OnInit } from '@angular/core';
import { Iprovider } from 'src/app/interface/Iprovider';
import { OrganicApiService } from 'src/app/service/organic-api.service';

@Component({
  selector: 'app-card-provider',
  templateUrl: './card-provider.component.html',
  styleUrls: ['./card-provider.component.css']
})
export class CardProviderComponent implements OnInit {

  constructor(private organicApiService: OrganicApiService) { }


  ngOnInit(): void {
    this.organicApiService.getProvider().subscribe(data => (this.provider = data)
    )

    this.organicApiService.getProviderById(3).subscribe(data => (console.log(data)))
  }

  provider!: Iprovider[];
}
