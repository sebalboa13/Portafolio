# Generated by Django 3.1.3 on 2021-10-28 21:32

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('main', '0013_facturaxxi_media'),
    ]

    operations = [
        migrations.AlterField(
            model_name='facturaxxi',
            name='media',
            field=models.FileField(null=True, upload_to='facturas/'),
        ),
    ]
